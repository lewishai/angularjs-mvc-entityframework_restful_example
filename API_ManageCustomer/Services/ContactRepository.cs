using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APICls.Models;

namespace APICls.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
        {
             new Contact
             {
                  Id = 1,
                  Name = "Glenn Block",
                  Phone =" 09123213123"
             },
             new Contact
             {
                  Id = 2,
                  Name = "Dan Roth",
                  Phone =" 09823432423"
             }
        };
        }
    }
}