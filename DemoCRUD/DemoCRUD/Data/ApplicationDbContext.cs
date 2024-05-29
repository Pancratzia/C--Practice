using DemoCRUD.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;



namespace DemoCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public DbSet<User> Usuarios { get; set; }
        public DbSet<Movement> Movimientos { get; set; }
    }

}
