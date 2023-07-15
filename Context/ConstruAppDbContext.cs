using ConstruAppAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ConstruAppAPI.Context
{
    public class ConstruAppDbContext : IdentityDbContext<IdentityUser>
    {
        public ConstruAppDbContext(DbContextOptions<ConstruAppDbContext> options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserAdmin> UserAdmins { get; set; }
        public DbSet<UserClient> UserClients { get; set; }
        public DbSet<UserSeller> UserSellers { get; set; }
    }
}
