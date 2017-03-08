using System.Collections.Generic;
using ContactManager.Models;

namespace ContactManager.DataAccess
{
    public interface IContactProvider
    {
        IEnumerable<Contact> GetContacts();
    }
}
