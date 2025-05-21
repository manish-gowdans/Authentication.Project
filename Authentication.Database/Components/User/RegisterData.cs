using Authentication.Database.Infrastructure;
using Authentication.Database.Models.User;

namespace Authentication.Database.Components.User;
public class RegisterData(DbContexts context) : IRegisterData
{
    public async Task RegisterUsers(string userName, string password)
    {
        var user = new Register
        {
            Name = userName,
            Email = password
        };
        context.Register.Add(user);
        await context.SaveChangesAsync();
    }
}
