using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Framework;

namespace Model.DAO
{
    public class DAOUser
    {
        ManagerDBContext context = null;
        public DAOUser()
        {
            context = new ManagerDBContext();
        }

        public long Insert(User entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }

        public User GetUserByID(string username)
        {
            return context.Users.SingleOrDefault(x => x.UserName == username);
        }

        public int Login(string username, string password)
        {
            var res = context.Users.SingleOrDefault(x => x.UserName == username && x.Password == password);
            if (res == null)
            {
                return 0;
            } else
            {
                if (res.Status == false)
                {
                    return -1;
                }
                else
                {
                    if (res.Password == password)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
        }
    }
}
