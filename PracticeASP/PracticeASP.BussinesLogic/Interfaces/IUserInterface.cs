using PracticeASP.Domain.Entities;

namespace PracticeASP.BussinesLogic.Interfaces
{
    public interface IUserInterface
    {
        bool UserAuthentificationAction(UAuthData UData);
        bool UserRegistrationAction(URegisterData UData);
    }
}
