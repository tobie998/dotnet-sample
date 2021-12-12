using Model.Framework;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class DAOProduct
    {
        ManagerDBContext context = null;
        public DAOProduct()
        {
            context = new ManagerDBContext();
        }

        public long Insert(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }

        //pagination in DB
        public IEnumerable<Product> ListAllPaging(int page, int pageSize)
        {
            return context.Products.OrderByDescending(x => x.Name).ToPagedList(page, pageSize);
        }
    }
}
