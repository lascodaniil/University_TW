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

namespace PracticeASP.Web.Controllers
{
    public class SigninController : Controller
    {
        private readonly IUserInterface _session;
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
        public ActionResult Signin(UserRegister model)
        {
            var UData = new URegisterData();

            UData.Prenumele = model.Prenumele;
            UData.Name = model.Name;
            UData.Email = model.Email;
            UData.Password = model.Password;
            UData.LastAuthDate = DateTime.Now;
            UData.IP_address = "192.168.0.1";
            
            var session = _session.UserRegistrationAction(UData);
            if (session)
            {
                var db = new TW_LABORATORIES();
                db.Users.Add(UData);
                db.SaveChanges();
            }
           return View();
        }
    }
}