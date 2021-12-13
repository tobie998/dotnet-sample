using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.Framework;
using PagedList.Mvc;

namespace nhatky_sanluongkhoan.Areas.Admin.Controllers
{
    public class ProductQuantityLogController : HomeController
    {
        // GET: Admin/ProductQuantityLog
        public ActionResult Index(int page = 1, int pageSize = 15)
        {
            var assignRecord = new DAOLog();
            var model = assignRecord.ListAllPaging(page, pageSize);
            return View(model);
        }

        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AssignRecord assignRecord)
        {
            if (ModelState.IsValid)
            {
                var recordData = new DAOLog();
                long id = recordData.Insert(assignRecord);
                if(id > 0)
                {
                    return RedirectToAction("Index", "ProductQuantityLog");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm nhật ký mới không thành công!");
                    return View("Index");
                }
            }
            return View("Index");
        }
    }
}