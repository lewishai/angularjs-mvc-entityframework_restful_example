using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntities.Entities;

namespace CustomerDAL
{
    public class CustomerDal:BaseDal
    {
        public Customer[] GetALL()
        {
            ManageCustomersEntities ctx = new ManageCustomersEntities();
            return ctx.Customers.ToArray();
        }

        public Customer GetByID(int id)
        {
            ManageCustomersEntities ctx = new ManageCustomersEntities();
            return ctx.Customers.Where(c => c.ID == id).ToArray()[0] as Customer;
        }

        public bool Insert(Customer cus)
        {
            try
            {
                ManageCustomersEntities ctx = new ManageCustomersEntities();
                ctx.Customers.Add(cus);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int id, Customer cus)
        {
            try
            {
                using (ManageCustomersEntities ctx = new ManageCustomersEntities())
                {
                    var _ob = ctx.Customers.SingleOrDefault(b => b.ID == id);
                    if (_ob != null)
                    {
                        _ob.Name = cus.Name.Trim();
                        _ob.Phone = cus.Phone.Trim();
                        _ob.Email = cus.Email.Trim();
                        _ob.Address = cus.Address.Trim();
                        ctx.SaveChanges();
                    }
                }

                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (ManageCustomersEntities ctx = new ManageCustomersEntities())
                {
                    var _ob = ctx.Customers.SingleOrDefault(b => b.ID == id);
                    if (_ob != null)
                    {
                        ctx.Customers.Remove(_ob);
                        ctx.SaveChanges();
                    }
                }

                return true;

            }
            catch
            {
                return false;
            }

        }

    }
}
