using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntities.Entities;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Reflection;

namespace CustomerDAL
{
    public class BaseDal
    {
        public ManageCustomersEntities _entities;
        static string _connectionString;
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString) == false)
                    return _connectionString;
                _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ManageCustomersEntities"].ConnectionString; //
                 return _connectionString;
            }
        }

        public BaseDal()
        {
            _entities = new ManageCustomersEntities(ConnectionString);
        }

    }
}
