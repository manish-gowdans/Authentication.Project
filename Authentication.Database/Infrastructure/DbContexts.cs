using Authentication.Database.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Database.Infrastructure;

public class DbContexts(DbContextOptions<DbContexts> options) : DbContext(options)
{
    public DbSet<Register> Register { get; set; }
}
