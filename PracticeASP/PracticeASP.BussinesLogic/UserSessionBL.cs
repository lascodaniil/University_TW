using PracticeASP.BussinesLogic.Core;
using PracticeASP.BussinesLogic.Interfaces;
using PracticeASP.Domain.Entities;

namespace PracticeASP.BussinesLogic.ActionBSLogic
{
    public class UserSessionBL : UserAPI, IUserInterface
    {
        public bool UserAuthentificationAction(UAuthData UData)
        {
            return UserAuth(UData);
        }

        public bool UserRegistrationAction(URegisterData UData)
        {
            return UserRegistration(UData);
        }
    }
}
