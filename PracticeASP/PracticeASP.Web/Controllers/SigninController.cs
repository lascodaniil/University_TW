using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeASP.Web.Models;
using PracticeASP.BussinesLogic.Interfaces;
using PracticeASP.BussinesLogic;
using PracticeASP.Domain.Entities;
using PracticeASP.BussinesLogic.DBModels;
using System.ComponentModel.DataAnnotations;
using PracticeASP.Helpers;

namespace PracticeASP.Web.Controllers
{
    public class SigninController : Controller
    {
        public TW_LABORATORIES db = new TW_LABORATORIES();
        private readonly IUserInterface _session;
        bool status;
        public SigninController()
        {
            var bussinesLogic = new MainBussinesLogic();
            _session = bussinesLogic.GetUserSessionBL();
        }


        [HttpGet]
        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signin(UserRegister model)
        {
            var UData = db.Users.Create();

            UData.Prenumele = model.Prenumele;
            UData.Name = model.Name;
            UData.Email = model.Email;
            UData.Password = LoginHelper.HashGen(model.Password);
            UData.LastAuthDate = DateTime.Now;
            UData.IP_address = Request.UserHostAddress; 
            UData.RoleID = 2;

            var session = _session.UserRegistrationAction(UData);
            if (session)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                db.Users.Add(UData);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
        }
    }
}