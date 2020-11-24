using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleData")))
            {
                var output = connection.Query<Person>($"select * from People where last_name = '{lastName}'").ToList();
                //var output = connection.Query<Person>("").ToList();
                return output;
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAdress, string genderIns, string creditCard)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleData")))
            {
                Person newPerson = new Person {first_name = firstName, last_name = lastName, email = emailAdress, gender = genderIns, Credit_card = creditCard };
                List<Person> people = new List<Person>();

                people.Add(newPerson);

                connection.Execute("");
            }
        }
    }
}
