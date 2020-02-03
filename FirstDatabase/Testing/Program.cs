using System;
using System.Data;
using System.Data.SqlClient;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter connection string:");
            string connectionString = Console.ReadLine();
            
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                //Create command
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Tickets WHERE Name = @0", conn);
                command.Parameters.Add(new SqlParameter("0", "HUNG"));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("FirstColumn\tSecond Column\t\tThird Column\t\tForth Column\t");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}",
                            reader[0], reader[1], reader[2], reader[3]));
                    }
                }
                Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                Console.ReadLine();

            }

        }
        private static void InsertData(SqlConnection connection, DataReader data)
        {

        }

        private static void InsertData(SqlConnection connection, Guid guid, string name, string vehicleId, string passport, string note, DateTime ticketDay, DateTime ticketIssue, string officer)
        {
            string insertData = "INSERT INTO dbo.Tickets VALUES(@guid, @name, @vehicleId, @passport, @note, @ticketDay, @ticketIssue, @officer)";
            using (SqlCommand querryInsert = new SqlCommand(insertData))
            {
                querryInsert.Connection = connection;
                querryInsert.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value = guid;
                querryInsert.Parameters.Add("@name", SqlDbType.NVarChar,50).Value = name;
                querryInsert.Parameters.Add("@vehicleId", SqlDbType.NVarChar, 50).Value = vehicleId;
                querryInsert.Parameters.Add("@passport", SqlDbType.NVarChar, 50).Value = passport;
                querryInsert.Parameters.Add("@note", SqlDbType.NVarChar, 250).Value = note;
                querryInsert.Parameters.Add("@officer", SqlDbType.NVarChar, 50).Value = officer;
                querryInsert.Parameters.AddWithValue("@ticketDay", ticketDay);
                querryInsert.Parameters.AddWithValue("@ticketDay", ticketIssue);

                connection.Open();

                querryInsert.ExecuteNonQuery();
            }

        }

        
    }
}
