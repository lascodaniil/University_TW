using PracticeASP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PracticeASP.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Article()
        {
            return View();
        }


        [HttpGet]
        public ActionResult APIView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult APIView(UserRegister userRegister)
        {
            return View();
        }




    }
}