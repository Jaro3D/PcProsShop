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
        public static String TestFunc()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
                        SELECT * FROM Item
                     ";
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader.GetString(2);
                        }

                        return "FAILURE";
                    }
                }
            }
        }
    }
}
