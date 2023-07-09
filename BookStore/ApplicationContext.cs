using System;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore
{
	public class ApplicationContext : DbContext
	{
        // Объекты таблицы
        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<BooksOnHand> BooksOnHand { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Past Your Connectiong String Here");
        }
    }
}

