using PracticeASP.BussinesLogic.DBModels;
using PracticeASP.Domain.Entities;
using PracticeASP.Helpers;
using PracticeASP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;



namespace PracticeASP.Web.Controllers
{
    public class WebAPIController : ApiController
    {
        public TW_LABORATORIES db = new TW_LABORATORIES();

        // GET /api/WebAPI
        public IEnumerable<URegisterData> GetUsers()
        {
            return db.Users.ToList();
        }

        // GET /api/WebAPI/Lasco
        public List<URegisterData> GetUser(int ID)
        {
          //  URegisterData user = db.Users.FirstOrDefault(u => u.RoleID == ID);

            List<URegisterData> user_list = db.Users.Where(u => u.RoleID == ID).ToList();
            
            

            return user_list;
        }

        // POST /api/WebAPI/CreateURegister 
        [HttpPost]
        public URegisterData CreateURegister(UserRegister uRegisterData)
        {

            var UData = new URegisterData();
            UData.Email = uRegisterData.Email;
            UData.Name = uRegisterData.Name;
            UData.Password = uRegisterData.Password;
            UData.Prenumele = uRegisterData.Prenumele;
            UData.RoleID = 2;
            UData.Password = LoginHelper.HashGen(uRegisterData.Password);
            UData.LastAuthDate = DateTime.Now;
            UData.IP_address = HttpContext.Current.Request.UserHostAddress;

            db.Users.Add(UData);
            db.SaveChanges();

            return UData;
        }

        //  api / WebAPI / UpdateURegister }

        [HttpPut]
        public URegisterData UpdateURegister(UserRegister uRegisterData)
        {
            URegisterData hUser = null;

            hUser = db.Users.FirstOrDefault(u => u.Email == uRegisterData.Email);

            if (hUser!=null)
            {

                hUser.Email = hUser.Email;
                hUser.Name = hUser.Name;
                hUser.Password = uRegisterData.Password;
                hUser.Prenumele = uRegisterData.Prenumele;
                hUser.RoleID = hUser.RoleID;
                hUser.Password = LoginHelper.HashGen(uRegisterData.Password);
                hUser.LastAuthDate = DateTime.Now;
                hUser.IP_address = HttpContext.Current.Request.UserHostAddress;
                db.SaveChanges();

                return hUser;

            }

            return null;


        }
        

    }
}
