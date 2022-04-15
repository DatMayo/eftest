using eftest.Models;
using Microsoft.EntityFrameworkCore;

namespace eftest.Database
{
    internal class DBConnect : DbContext
    {
        private const string ConnectionString = "server=localhost;port=3306;database=test;user=root;password=root";

        public DbSet<Account> Account { get; set; }
        public DbSet<Log> Log { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ServerVersion sv = ServerVersion.AutoDetect(ConnectionString);
            optionsBuilder.UseMySql(ConnectionString, sv);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
            //modelBuilder.Entity<Account>().HasKey(x => x.Id);
        }
    }
}
