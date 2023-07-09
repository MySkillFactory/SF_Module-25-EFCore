using FirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApp
{
	public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }

        // Объекты таблицы UserCredentials
        public DbSet<UserCredential> UserCredentials { get; set; }

        // Объекты таблицы Companies
        public DbSet<Company> Companies { get; set; }


        /*public AppContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Past Your Connectiong String Here");
        }
    }
}