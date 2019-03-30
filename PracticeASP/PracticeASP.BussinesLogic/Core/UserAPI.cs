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
            var user = db.Users.FirstOrDefault(m => m.Email == data.Email &&  m.Password.Equals(data.Password));
            if(user !=null)
            {
                return true;
            }
            return true;
        }

        internal bool UserRegistration(URegisterData data)
        {
            return true;
        }
    }
}
