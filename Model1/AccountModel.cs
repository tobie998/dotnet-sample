using Model1.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public class AccountModel
    {
        private MyDB context = null;
        public AccountModel()
        {
            context = new MyDB();
        }
        public bool Login(string userName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@userName", userName),
                new SqlParameter("@password", password)
            };
            var res = context.Database.SqlQuery<bool>("Account_Login @userName, @password",sqlParams).SingleOrDefault();
            return res;
        }
    }
}
