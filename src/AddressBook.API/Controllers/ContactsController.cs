using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using AddressBook.Data;
using AddressBook.Data.Entities;

namespace AddressBook.Api.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {

        public IRepository<Contact> Contacts { get; set; }

        public ContactsController(IRepository<Contact> contacts)
        {
            Contacts = contacts;
        }

        [HttpGet]
        public IEnumerable<Contact> GetAll()
        {
            return Contacts.GetAll();
        }

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var item = Contacts.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
