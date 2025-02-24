using Microsoft.EntityFrameworkCore;
using BooksellerApp.Models;
using System.Reflection;
using User = BooksellerApp.Models.User;

namespace BooksellerApp.Data
{
    internal class SahafDBContext : DbContext
    {
        //dbset
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book_Author> BookAuthors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionString");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            // BookAuthor tablosu için primary key tanımlama
            modelBuilder.Entity<Book_Author>()
                .HasKey(ba => new { ba.Book_AuthorID });

            // BookAuthor tablosu için ilişkileri tanımlama
            modelBuilder.Entity<Book_Author>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.Book_Authors)
                .HasForeignKey(ba => ba.BookID);

            modelBuilder.Entity<Book_Author>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.Book_Authors)
                .HasForeignKey(ba => ba.AuthorID);

            // Book-Publisher için ilişkileri tanımlama
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherID);

            // Book-Category için ilişkileri tanımlama
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryID);

            // Book-User için ilişkileri tanımlama
            modelBuilder.Entity<Book>()
                .HasOne(b => b.User)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.UserID);
        }
    }
}
