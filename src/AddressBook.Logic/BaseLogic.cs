using AddressBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Logic
{
    public abstract class BaseLogic
    {
        public readonly string ConnectionStringName;

        public BaseLogic(string connectionStringName)
        {
            ConnectionStringName = connectionStringName;
        }

        //protected T GetDataContext<T>() where T: SqlRepositoryContext<T>
        //{
            
        //}
    }
}
