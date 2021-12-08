using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Areas.Admin.Code;
using Demo.Areas.Admin.Data;
using Model1;

namespace Demo.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            var result = new AccountModel().Login(model.UserName, model.Password);
            if (result && ModelState.IsValid) {
                SessionHelper.SetSession(new UserSession() {UserName = model.UserName });
                return RedirectToAction("Index", "Home");
            } else {
                ModelState.AddModelError("", "Username or Password is invalid");
            }
            return View(model);
        }
    }
}