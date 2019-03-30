using PracticeASP.BussinesLogic.ActionBSLogic;
using PracticeASP.BussinesLogic.Interfaces;

namespace PracticeASP.BussinesLogic
{
    public class MainBussinesLogic
    {
        public IUserInterface GetUserSessionBL()
        {
            return new UserSessionBL();
        }
    }
}
