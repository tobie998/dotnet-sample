using Model.DAO;
using nhatky_sanluongkhoan.Areas.Admin.Data;
using nhatky_sanluongkhoan.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nhatky_sanluongkhoan.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if(ModelState.IsValid)
            {
                var userDao = new DAOUser();
                var result = userDao.Login(login.Username, login.Password);
                if (result)
                {
                    var user = userDao.GetUserByID(login.Username);
                    var userSession = new UserSession();
                    userSession.Username = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(ConstantSession.USER_SESSION, userSession);
                    return RedirectToAction("Home", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login is error");
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
            
        }
    }
}