using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Testing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"..\..\..\..\..\csv\data.csv";
            DataReader reader = new DataReader("TRUNG", path);
            reader.PrintData();

            //Console.WriteLine("Enter connection string:");
            string connectionString = "Server = localhost; Database = TutorialDB; Trusted_Connection = True;";

            //Insert data to table from csv file
            InsertData(connectionString, reader);
        }

        private static void InsertData(string connectionString, DataReader data)
        {
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                foreach (var ticket in data.Tickets)
                {
                    InsertData(connection, ticket.GuidID, ticket.Name, ticket.VehicleID, ticket.Passport, ticket.Notes, ticket.TicketDay, ticket.TicketIssue, ticket.Officer);
                }
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            
        }

        private static void InsertData(SqlConnection connection, Guid guid, string name, string vehicleId, string passport, string note, DateTime ticketDay, DateTime ticketIssue, string officer)
        {
            string insertData = "INSERT INTO dbo.Tickets VALUES(@guid, @name, @vehicleId, @passport, @note, @ticketDay, @ticketIssue, @officer)";
            using (SqlCommand querryInsert = new SqlCommand(insertData))
            {
                querryInsert.Connection = connection;
                querryInsert.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value = guid;
                querryInsert.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
                querryInsert.Parameters.Add("@vehicleId", SqlDbType.NVarChar, 50).Value = vehicleId;
                querryInsert.Parameters.Add("@passport", SqlDbType.NVarChar, 50).Value = passport;
                querryInsert.Parameters.Add("@note", SqlDbType.NVarChar, 250).Value = note;
                querryInsert.Parameters.Add("@officer", SqlDbType.NVarChar, 50).Value = officer;
                querryInsert.Parameters.AddWithValue("@ticketDay", ticketDay);
                querryInsert.Parameters.AddWithValue("@ticketIssue", ticketIssue);

                querryInsert.ExecuteNonQuery();
            }
        }
    }
}