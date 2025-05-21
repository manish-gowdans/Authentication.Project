namespace Authentication.Database.Components.User;
public interface IRegisterData
{
    Task RegisterUsers(string userName, string password);
}
