using nhatky_sanluongkhoan.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace nhatky_sanluongkhoan.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Home()
        {
            //var sessionObj = (UserSession)Session[ConstantSession.USER_SESSION];
            //if (sessionObj != null)
            {
                //var name = sessionObj.Username;
                //var ID = sessionObj.UserID;
                //Response.Write($"{name} with {ID}");
                return View();
            }
            //else
            //{
            //    return RedirectToAction("Index", "Login");
            //}
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var sess = (UserSession)Session[ConstantSession.USER_SESSION];
            if (sess == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { Controller = "Login", Action = "Index", Areas = "Admin" }));
            }
            base.OnActionExecuted(filterContext);
        }
    }
}