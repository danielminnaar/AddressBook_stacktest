using AddressBook.Data.Entities;
using AddressBook.Data.Repositories.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Logic
{
    public class ContactsLogic : BaseLogic
    {
        public ContactsLogic() : base("AddressBook")
        {
        }

        public Contact GetById(int id)
        {
            var repo = new ContactRepository(this.ConnectionStringName);
            return repo.GetById(id);
        }

        public List<Contact> GetAllContacts()
        {
            var repo = new ContactRepository(this.ConnectionStringName);
            return repo.GetAll().ToList();
        }

        public void Update(Contact item)
        {
            var repo = new ContactRepository(this.ConnectionStringName);
            // some server-side validation here if necessary
            repo.Update(item);
        }
    }
}
