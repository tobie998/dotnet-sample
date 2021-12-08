using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models.Framework;

namespace Models
{
    public class AccountModel
    {
        private DemoDBContext context = null;

        public AccountModel()
        {
            context = new DemoDBContext();
        }

        public bool Login(string userName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@userName", userName),
                new SqlParameter("@password", password)

            };
            var res = context.Database.SqlQuery<bool>("Exec Account_Login @userName, @password", sqlParams).SingleOrDefault();
            return res;
            //try
            //{
            //    var res = context.Database.SqlQuery<bool>("Account_Login @userName, @password", sqlParams).SingleOrDefault();
            //    return res;
            //} catch
            //{
            //    return false;
            //}    
        }
    }
}
