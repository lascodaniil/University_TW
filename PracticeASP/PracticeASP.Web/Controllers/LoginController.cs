using PracticeASP.BussinesLogic;
using PracticeASP.BussinesLogic.Interfaces;
using PracticeASP.Domain.Entities;
using PracticeASP.Web.Models;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace PracticeASP.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserInterface _session;
        bool status;
        public static UserLogin general = new UserLogin();
        public LoginController()
        {
            var bussinesLogic = new MainBussinesLogic();
            _session = bussinesLogic.GetUserSessionBL();
        }


        [HttpGet]
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin model)
        {
            if (ModelState.IsValid)
            {
                var _user = new UAuthData();
                _user.Email = model.Email;
                _user.Password = model.Password;
                _user.LastAuthDate = DateTime.Now;
                _user.IP_address = "192.168.0.1";
                status = _session.UserAuthentificationAction(_user);
            }

            FormsAuthentication.SetAuthCookie(model.Email, false);
            if (status)
            {
                general = model;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}

