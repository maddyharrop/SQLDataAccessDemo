using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                // var output = connection.Query<Person>($"select * from People where LastName = '{ lastName } '").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { lastName = lastName }).ToList();
                return output;
            }
        }

        public string InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                // Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber }; Not needed to repeat
                SqlCommand cmd = new SqlCommand("dbo.People_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FirstName", firstName);
                cmd.Parameters.AddWithValue("LastName", lastName);
                cmd.Parameters.AddWithValue("EmailAddress", emailAddress);
                cmd.Parameters.AddWithValue("PhoneNumber", phoneNumber);
                connection.Open();
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                     return  "Record Inserted Succesfully into the Database";
                }
                else
                {
                    return "Record insert failed";

                }
               // List<Person> people = new List<Person>();

                ///people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

                //connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}
