using AddressBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AddressBook.Data
{
    public interface IRepository<T> where T: Base
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
