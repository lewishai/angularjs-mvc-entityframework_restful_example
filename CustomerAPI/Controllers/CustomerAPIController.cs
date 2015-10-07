using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using CustomerEntities.Entities;
using CustomerBLL;
using System.Web.Routing;

namespace CustomerAPI.Controllers
{
   
      //[Authorize]
    public class CustomerAPIController : ApiController
    {
        public CustomerAPIController()
        {
        }
        [AllowAnonymous]
        public Customer[] Get()
        {
            var cusDLL = new CusDLL();
            return cusDLL.GetAll();
        }

        [HttpPost]
        public HttpResponseMessage Post(Customer customer)
        {
            var cusDLL = new CusDLL();
            if (customer.ID == 0)
            {
                cusDLL.Insert(customer);
            }
            else
            {
                cusDLL.Update( customer,customer.ID);
            }
           HttpResponseMessage response = Request.CreateResponse<Customer>(System.Net.HttpStatusCode.Created, customer);
            return response;
        }

        // DELETE api/values/5
        [HttpDelete]
        public virtual HttpResponseMessage Delete(int id)
        {
            var cusDLL = new CusDLL();
            if (id != 0)
            {
                cusDLL.Delete(id);
            }
            HttpResponseMessage response = Request.CreateResponse<int>(System.Net.HttpStatusCode.Created, id);
            return response;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

    }
}
