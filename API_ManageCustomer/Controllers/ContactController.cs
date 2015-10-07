using APICls.Models;
using APICls.Services;
using System.Net.Http;
using System.Web.Http;

namespace APICls.Controllers
{
    public class ContactController : ApiController
    {
        private readonly ContactRepository contactRepository;
        private readonly ContactRepository_RW contactRepository_RW;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
            contactRepository_RW = new ContactRepository_RW();
        }

        //public string[] Get()
        public Contact[] Get()
        {
            //    return new string[]
            //{
            //     "Hello",
            //     "World"
            //};

            //  return new Contact[]

            //return new Contact[]
            //{
            //    new Contact
            //    {
            //        Id = 1,
            //        Name = "Glenn Block"
            //    },
            //    new Contact
            //    {
            //        Id = 2,
            //        Name = "Dan Roth"
            //    }
            //};

            return contactRepository.GetAllContacts();
        }

        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository_RW.SaveContact(contact);

            HttpResponseMessage response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
    }
}