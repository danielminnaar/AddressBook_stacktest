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
        private string Tags { get; set; }

        public List<string> TagList
        {
            get
            { 
                return Tags.Split(';').ToList();
            }
            set
            {
                Tags = String.Join(";", value);
            }
        }
    }
}
