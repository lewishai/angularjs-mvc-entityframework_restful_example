using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntities.Entities;
using CustomerDAL;
namespace CustomerBLL
{
    public class CusDLL
    {
        public Customer[] GetAll()
        {
            CustomerDal CusDAL = new CustomerDal();
            return CusDAL.GetALL();
        }
        public Customer GetById(int id)
        {
            CustomerDal CusDAL = new CustomerDal();
            return CusDAL.GetByID(id);
        }

        public void Insert(Customer cus)
        {
            CustomerDal CusDAL = new CustomerDal();
        }

        public void Update(Customer cus, int id)
        {
            CustomerDal CusDAL = new CustomerDal();
            CusDAL.Update( id,cus);
        }

         public void Delete(int id)
        {
            CustomerDal CusDAL = new CustomerDal();
            CusDAL.Delete(id);
        }
    }
}
