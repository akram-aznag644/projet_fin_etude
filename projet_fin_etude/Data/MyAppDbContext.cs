using Microsoft.EntityFrameworkCore;
using projet_fin_etude.Data;
using projet_fin_etude.Data.Config;

namespace projet_fin_etude.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UserConfig());


        }
    }
}
