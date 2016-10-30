using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Data.Entities
{
    public class Contact : Base
    {
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string LinkedInUrl { get; set; }
        public string SkypeUserName { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        private string _tags { get; set; }

        public List<string> Tags
        {
            get
            { 
                return _tags.Split(';').ToList();
            }
            set
            {
                _tags = String.Join(";", value);
            }
        }
    }
}
