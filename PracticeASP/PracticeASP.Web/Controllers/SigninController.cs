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
        public ActionResult Signin(UserRegister model)
        {
            URegisterData UData = new URegisterData();
            UData.Prenumele = model.Prenumele;
            UData.Name = model.Name;
            UData.Email = model.Email;
            UData.Password = model.Password;
            UData.LastAuthDate = DateTime.Now;
            UData.IP_address = "192.168.0.1";
            UData.RoleID = 1;

            var session = _session.UserRegistrationAction(UData);
            if (session)
            {
                return View("Existing");
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