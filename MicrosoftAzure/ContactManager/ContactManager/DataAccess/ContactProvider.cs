using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ContactManager.Models;

namespace ContactManager.DataAccess
{
    public class ContactProvider : IContactProvider
    {
        private string connectionString;

        public ContactProvider()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public IEnumerable<Contact> GetContacts()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("select * from GlobalDevelopers.dbo.Contacts", connection))
                {
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    var reader = command.ExecuteReader();

                    var contacts = new List<Contact>();

                    while (reader.Read())
                    {
                        contacts.Add(new Contact
                        {
                            ContactId = (int)reader["ContactId"],
                            Name = reader["Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            Zip = reader["Zip"].ToString(),
                            Email= reader["Email"].ToString(),
                        });
                    }

                    return contacts;
                }
            }
        }
    }
}