namespace Authentication.Service.Components.User.Token;
public interface ITokenService
{
    string GenerateToken(string userName, string userRole);
}
