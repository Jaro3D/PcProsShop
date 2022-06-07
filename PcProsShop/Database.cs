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
        static string connectionString = "Server=tcp:pc-pros-shop.database.windows.net,1433;Initial Catalog=pc-pros-shop-database;Persist Security Info=False;User ID=PCPros;Password=HJGVdzz2t23sd.edw;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Just a test function which has to be deleted later
        public static Item[] LoadInventory(Category category)
        {
            Item[] inventory = new Item[20];

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Item WHERE category = '"+ category +"'";
                    
                    connection.Open();
                    MessageBox.Show("In command");

                    using (var reader = command.ExecuteReader())
                    {
                        MessageBox.Show("In reader");
                        int index = 0;
                        while (reader.Read())
                        {
                            Item tempItem = new Item();
                            MessageBox.Show(reader["name"].ToString());
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
    }
}
