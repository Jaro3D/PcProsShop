using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PcProsShop
{
    internal class Database
    {

        /*
         * Use Encryption.getConnectionString("StringDB"); to fetch connectionString from app.config
         * Maybe need to import "System.Configuration.ConfigurationManager" via NuGet
         */
        static string connectionString = "Server=tcp:pc-pros-shop.database.windows.net,1433;Initial Catalog=pc-pros-shop-database;Persist Security Info=False;User ID=PCPros;Password=HJGVdzz2t23sd.edw;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Just a test function which has to be deleted later
        public static Item[] LoadInventory(Category category)
        {
            Item[] inventory = new Item[20];

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();

                    command.CommandText = @"SELECT count(*) FROM Item WHERE category = @category";
                    command.Parameters.AddWithValue("@category", Convert.ToString(category));

                    //Capture how many items were selected
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());

                    inventory = new Item[count];

                    command.CommandText = @"SELECT * FROM Item WHERE category = @category ORDER BY price";

                    using (var reader = command.ExecuteReader())
                    {
                        int index = 0;
                        while (reader.Read())
                        {
                            Item tempItem = new Item();
                            tempItem.ItemID = Convert.ToInt32(reader["id"]);
                            tempItem.Name = reader["name"].ToString();
                            tempItem.Brand = reader["brand"].ToString();
                            tempItem.Info = reader["info"].ToString();
                            tempItem.Category = reader["category"].ToString();
                            tempItem.Amount = Convert.ToInt32(reader["amount"]);
                            tempItem.Price = Convert.ToDouble(reader["price"]);

                            inventory[index] = tempItem;

                            index++;
                        }

                        return inventory;
                    }
                }
            }
        }

        public static void CreateAccount(Account account)
        {
            //Encryption
            byte[] iv = Encryption.createIV();
            byte[] key = Encryption.createKey(account.Password);
            string identifier = Encryption.createHash(account.Mail);

            account = Encryption.encryptAccount(account, key, iv);

            string ivString = Convert.ToBase64String(iv);

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = @"INSERT INTO Account (firstName, lastName, email, passwort, city, street, zipCode, isAdmin, iv, identifier)
                    VALUES(@firstName, @lastName, @email, @password, @city, @street, @zipCode, @isAdmin, @iv, @identifier)";

                    command.Parameters.AddWithValue("@firstName", account.Fname);
                    command.Parameters.AddWithValue("@lastName", account.Lname);
                    command.Parameters.AddWithValue("@email", account.Mail);
                    command.Parameters.AddWithValue("@password", account.Password);
                    command.Parameters.AddWithValue("@city", account.City);
                    command.Parameters.AddWithValue("@street", account.Street);
                    command.Parameters.AddWithValue("@zipCode", account.Zip);
                    command.Parameters.AddWithValue("@isAdmin", account.IsAdmin);
                    command.Parameters.AddWithValue("@iv", ivString);
                    command.Parameters.AddWithValue("@identifier", identifier);

                    command.ExecuteNonQuery();

                }
            }
        }

        public static Account LoadAccount(string email, string password)
        {
            Account account = new Account("Test");
            string identifier = Encryption.createHash(email);
            string iv = "";
            byte[] key = Encryption.createKey(password);

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();

                    command.CommandText = @"SELECT * FROM Account WHERE identifier = @identifier";
                    command.Parameters.AddWithValue("@identifier", identifier);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            account.Id = Convert.ToInt32(reader["id"]);
                            account.Fname = reader["firstName"].ToString();
                            account.Lname = reader["lastName"].ToString();
                            account.Mail = reader["email"].ToString();
                            account.Password = reader["passwort"].ToString();
                            account.City = reader["city"].ToString();
                            account.Street = reader["street"].ToString();
                            account.Zip = reader["zipCode"].ToString();
                            account.IsAdmin = Convert.ToInt32(reader["isAdmin"]);
                            iv = reader["iv"].ToString();
                        }

                        byte[] byteIv = Convert.FromBase64String(iv);

                        account = Encryption.decryptAccount(account, key, byteIv);

                        return account;
                    }
                }
            }
        }

        public static bool CheckIfEmailExists(string email)
        {
            string identifier = Encryption.createHash(email);

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();

                    command.CommandText = @"SELECT * FROM Account WHERE identifier = @identifier";
                    command.Parameters.AddWithValue("@identifier", identifier);

                    //Capture how many items were selected
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
