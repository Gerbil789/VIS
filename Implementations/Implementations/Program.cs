using BussinessLayer;
using DataLayer;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Implementations{
    class Program{
        static void Main(string[] args){
            
            Test();
            
        }

        public static void Test()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString)){
           
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT TOP 10 first_name, last_name FROM actor;";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                    }
                }
            }
        }
    }

    
}