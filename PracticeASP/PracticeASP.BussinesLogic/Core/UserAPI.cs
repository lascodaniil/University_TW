using PracticeASP.Domain.Entities;
using PracticeASP.BussinesLogic.DBModels;
using System.Linq;

namespace PracticeASP.BussinesLogic.Core
{
    public class UserAPI
    {
        internal bool UserAuth(UAuthData data)
        {
            var db = new TW_LABORATORIES();
            
            
            var user = db.Users.FirstOrDefault(u => u.Email.Equals(data.Email)  &&  u.Password==data.Password);
            if(user !=null)
            {
                return true;
            }
            return false;
            
        }

        internal bool UserRegistration(URegisterData data)
        {
            var db = new TW_LABORATORIES();
           var user = db.Users.FirstOrDefault(u => u.Email.Equals(data.Email));

            if(user!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
