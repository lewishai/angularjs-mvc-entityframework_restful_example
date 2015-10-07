using Enitties.DAL;
using Enitties.Entities;
using System.Net.Http;
using System.Web.Http;

namespace APICls.Controllers
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
            #region close code

            //    return new string[]
            //{
            //     "Hello",
            //     "World"
            //};

            //  return new Contact[]

            //return new Customer[]
            //{
            //    new Enitties.Entities.Customer
            //    {
            //        ID =1,
            //        Name = "Hong Chau",
            //        Phone ="0912312312",
            //        Address = "Tphcm",
            //        Email = "hxhai02@yahoo.com"
            //    },
            //    new Enitties.Entities.Customer
            //    {
            //        ID=2,
            //        Name = "Quoc Chuong",
            //        Phone ="09123123034",
            //        Address = "Tphcm",
            //        Email = "hxhai02@yahoo.com"
            //    },
            //    new Enitties.Entities.Customer
            //    {
            //        ID =1,
            //        Name = "Quang Trung",
            //        Phone ="0912312312",
            //        Address = "Tphcm",
            //        Email = "hxhai02@yahoo.com"
            //    },
            //    new Enitties.Entities.Customer
            //    {
            //        ID =1,
            //        Name = "Thanh Thao",
            //        Phone ="0912312312",
            //        Address = "Tphcm",
            //        Email = "hxhai02@yahoo.com"
            //    },
            //    new Enitties.Entities.Customer
            //    {
            //        ID =1,
            //        Name = "Xuan Hai",
            //        Phone ="0912312312",
            //        Address = "Tphcm",
            //        Email = "hxhai02@yahoo.com"
            //    }
            //};

            #endregion close code

            CustomerDal CusDAL = new CustomerDal();
            return CusDAL.GetALL();
        }

        [HttpPost]
        public HttpResponseMessage Post(Customer customer)
        {
            var cusDal = new CustomerDal();
            if (customer.ID == 0)
            {
                cusDal.Insert(customer);
            }
            else
            {
                cusDal.Update(customer.ID, customer);
            }
            HttpResponseMessage response = Request.CreateResponse<Customer>(System.Net.HttpStatusCode.Created, customer);
            return response;
        }

        // DELETE api/values/5
        [HttpDelete]
        public virtual HttpResponseMessage Delete(int id)
        {
            CustomerDal CusDAL = new CustomerDal();
            if (id != 0)
            {
                CusDAL.Delete(id);
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