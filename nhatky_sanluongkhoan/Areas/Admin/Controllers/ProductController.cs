using Model.DAO;
using Model.Framework;
using nhatky_sanluongkhoan.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;

namespace nhatky_sanluongkhoan.Areas.Admin.Controllers
{
    public class ProductController : HomeController
    {
        // GET: Admin/Product
        public ActionResult Index(int page = 1, int pageSize = 15)
        {
            //check session when logging in
            //var sessionObj = (UserSession)Session[ConstantSession.USER_SESSION];
            //if (sessionObj != null)
            //{
            //    var name = sessionObj.Username;
            //    var ID = sessionObj.UserID;
            //    //Response.Write($"{name} with {ID}");
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Login");
            //}

            var productData = new DAOProduct();
            var model = productData.ListAllPaging(page, pageSize);
            return View(model);
        }

        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var productData = new DAOProduct();
                long id = productData.Insert(product);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Product");
                } 
                else
                {
                    ModelState.AddModelError("", "Cannot add new product!");
                    return View("CreateForm");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var productData = new DAOProduct();
            var model = productData.ViewByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                var productData = new DAOProduct();
                bool id = productData.Update(product);
                if (id)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Cannot update new product!");
                    return View("Update");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var productData = new DAOProduct();
            productData.Delete(id);
            return RedirectToAction("Index", "Product");
        }
    }
}