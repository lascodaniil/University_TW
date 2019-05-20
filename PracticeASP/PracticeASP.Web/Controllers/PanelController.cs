using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeASP.BussinesLogic.DBModels;
using PracticeASP.BussinesLogic.Interfaces;
using PracticeASP.Domain.Entities;
using System.Data;

namespace PracticeASP.Web.Controllers
{
    public class PanelController : Controller
    {
        // GET: Panel
        public TW_LABORATORIES db = new TW_LABORATORIES();

        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            IEnumerable<URegisterData> users = db.Users.ToList();
            return View(users);
        }

        [Authorize(Roles = "user")]
        public ActionResult Index1()
        {
            URegisterData user= new URegisterData();
            user = db.Users.FirstOrDefault(x =>x.Email == LoginController.general.Email);
            if (user!=null)
            {
                return View(user);
            }
            return View();
        }
    }
}