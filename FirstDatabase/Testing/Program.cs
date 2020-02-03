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

        
    }
}
