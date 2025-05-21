namespace Authentication.Service.Components.User.Register;

public interface IRegisterService
{
    Task RegisterUsers(string userName, string password);
}
