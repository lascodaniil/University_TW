using PracticeASP.BussinesLogic;
using PracticeASP.BussinesLogic.Interfaces;
using PracticeASP.Domain.Entities;
using PracticeASP.Web.Models;
using System;
using System.Web.Mvc;


namespace PracticeASP.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserInterface _session;
        bool status;
        public LoginController()
        {
            var bussinesLogic = new MainBussinesLogic();
            _session = bussinesLogic.GetUserSessionBL();
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

            if (status)
            {
                return View("Existing");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}

