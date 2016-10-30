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
        private readonly string _tableName;
        private string _connectionString;

        internal IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public ContactRepository(string connectionString, string tableName)
        {
            _connectionString = connectionString;
            _tableName = tableName;
        }

        public void Insert(Contact item)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact item)
        {
            using (var cn = Connection)
                cn.Execute(String.Format("UPDATE {0} SET [FullName] = @FullName, [Company] = @Company, [Title] = @Title, [SkypeUserName] = @SkypeUserName, [LinkedInUrl] = @LinkedInUrl, [EmailAddress] = @EmailAddress, [PhoneNumber] = @PhoneNumber WHERE Id = {1}", _tableName, item.Id.ToString()), item);
        }

        public void Delete(Contact item)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            using (var db = Connection)
                return db.Query<Contact>(String.Format("SELECT * FROM {0} WHERE Id = {1}", _tableName, id.ToString())).SingleOrDefault();
        }

        public IEnumerable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> Find(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
