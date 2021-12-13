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

        //insert new record
        public long Insert(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }

        //update record
        public bool Update(Product entity)
        {
            try
            {
                var product = context.Products.Find(entity.ID);
                product.Name = entity.Name;
                product.RegisterCode = entity.RegisterCode;
                product.ExpireDate = entity.ExpireDate;
                product.RegisterDate = entity.RegisterDate;
                product.Description = entity.Description;
                product.ModifiedDate = entity.ModifiedDate;
                context.SaveChanges();
                return true;
            } 
            catch (Exception error)
            {
                return false;
            }
        }

        //public Product GetByID(string productName)
        //{
        //    return context.Products.SingleOrDefault(x => x.Name == productName);
        //}

        public Product ViewByID(int id)
        {
            return context.Products.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                var product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
                return true;
            } 
            catch (Exception error)
            {
                Console.WriteLine("Xóa không thành công", error);
                return false;
            }
        }

        //pagination in DB
        public IEnumerable<Product> ListAllPaging(int page, int pageSize)
        {
            return context.Products.OrderBy(x => x.ID).ToPagedList(page, pageSize);
        }
    }
}
