using Authentication.Database.Components.User;

namespace Authentication.Service.Components.User.Register;
public class RegisterService(IRegisterData registerData) : IRegisterService
{
    public async Task RegisterUsers(string userName, string password)
    {
        await registerData.RegisterUsers(userName, password);
    }
}
