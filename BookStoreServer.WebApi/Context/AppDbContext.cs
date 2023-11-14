using BookStoreServer.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreServer.WebApi.Context;

public sealed class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=INANGUCLU\\SQLEXPRESS;Initial Catalog=BookStoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");


    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCategory> bookCategories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().OwnsOne(p => p.Price,price =>
        {
            price.Property(p=>p.Value).HasColumnType("money");
            price.Property(p=> p.Currency).HasMaxLength(5);
        });
        modelBuilder.Entity<BookCategory>().HasKey(p => new { p.BookId, p.CategoryId });

        // domain driven desing
        //value object

        // value object kullanıyorsak seed data kullanamıyoruz 
        

        


    }

}
