using System;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AddressBook.Data.Entities;

namespace AddressBook.Data.Repositories.SQL
{
    public class ContactRepository : IRepository<AddressBook.Data.Entities.Contact>
    {
        private string _connectionString;

        public IDbConnection GetConnection() // factory-ize this
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public ContactRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Insert(Contact item)
        {
            throw new NotImplementedException("Insert()");
        }

        public void Update(Contact item)
        {
            using (var cn = GetConnection())
                cn.Execute(String.Format("UPDATE Contacts SET [FullName] = @FullName, [Company] = @Company, [Title] = @Title, [SkypeUserName] = @SkypeUserName, [LinkedInUrl] = @LinkedInUrl, [EmailAddress] = @EmailAddress, [PhoneNumber] = @PhoneNumber WHERE Id = {0}", item.Id.ToString()), item);
        }

        public void Delete(Contact item)
        {
            throw new NotImplementedException("Delete()");
        }

        public Contact GetById(int id)
        {
            using (var db = GetConnection())
                return db.Query<Contact>(String.Format("SELECT * FROM Contacts WHERE Id = {0}", id.ToString())).SingleOrDefault();
        }

        public IEnumerable<Contact> GetAll()
        {
            using (var db = GetConnection())
                return db.Query<Contact>(String.Format("SELECT * FROM Contacts"));
        }

    }
}
