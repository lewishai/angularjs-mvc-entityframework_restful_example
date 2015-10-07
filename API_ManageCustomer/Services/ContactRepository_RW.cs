using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APICls.Models;

namespace APICls.Services
{
    public class ContactRepository_RW
    {
        private const string CacheKey = "ContactStore";

        /// <summary>
        /// Create via cache the "ContactStore" key.
        /// </summary>
        public ContactRepository_RW()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                if (ctx.Cache[CacheKey] == null)
                {
                    var contacts = new Contact[]
            {
                new Contact
                {
                    Id = 1, Name = "Glenn Block 1", Phone ="406845645"
                },
                new Contact
                {
                    Id = 2, Name = "Dan Roth 1", Phone="09234823423"
                }
            };

                    ctx.Cache[CacheKey] = contacts;
                }
            }
        }


        public Contact[] GetAllContacts()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                return (Contact[])ctx.Cache[CacheKey];
            }

            return new Contact[]
            {
                new Contact
                {
                    Id = 0,
                    Name = "Placeholder"
                }
            };
        }

        public bool SaveContact(Contact contact)
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    var currentData = ((Contact[])ctx.Cache[CacheKey]).ToList();
                    currentData.Add(contact);
                    ctx.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }

            return false;
        }

    }
}