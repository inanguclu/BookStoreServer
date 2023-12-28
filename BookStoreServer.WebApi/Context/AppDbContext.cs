﻿using BookStoreServer.WebApi.Models;
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
    public DbSet<BookCategory> BookCategories { get; set; }
    public DbSet<Order> Orders { get; set; }    
    public DbSet<OrderStatus> OrderStatuses { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderStatus>().HasIndex(p => 
        new { p.Status,p.OrderNumber}).IsUnique();


        modelBuilder.Entity<Book>().OwnsOne(p => p.Price, price =>
        {
            price.Property(p => p.Value).HasColumnType("money");
            price.Property(p => p.Currency).HasMaxLength(5);
        });

        modelBuilder.Entity<Order>().OwnsOne(p => p.Price, price =>
        {
            price.Property(p => p.Value).HasColumnType("money");
            price.Property(p=>p.Currency).HasMaxLength(5);  
        });

        modelBuilder.Entity<BookCategory>().HasKey(p => new { p.BookId, p.CategoryId });

        // domain driven desing
        //value object

        // value object kullanıyorsak seed data kullanamıyoruz 

        modelBuilder.Entity<Category>().HasData(//seed data basıyoruz 
            new Category { Id = 1, Name = "Korku", IsActive = true, IsDeleted = false },
            new Category { Id = 2, Name = "Bilim Kurgu", IsActive = true, IsDeleted = false },
            new Category { Id = 3, Name = "Tarih", IsActive = true, IsDeleted = false },
            new Category { Id = 4, Name = "Edebiyat", IsActive = true, IsDeleted = false },
            new Category { Id = 5, Name = "Çocuk", IsActive = true, IsDeleted = false },
            new Category { Id = 6, Name = "Psikoloji", IsActive = true, IsDeleted = false },
            new Category { Id = 7, Name = "Din", IsActive = true, IsDeleted = false },
            new Category { Id = 8, Name = "Felsefe", IsActive = true, IsDeleted = false },
            new Category { Id = 9, Name = "Bilim", IsActive = true, IsDeleted = false },
            new Category { Id = 10, Name = "Sanat", IsActive = true, IsDeleted = false },
            new Category { Id = 11, Name = "Spor", IsActive = true, IsDeleted = false },
            new Category { Id = 12, Name = "Gezi", IsActive = true, IsDeleted = false },
            new Category { Id = 13, Name = "Dergi", IsActive = true, IsDeleted = false },
            new Category { Id = 14, Name = "Mizah", IsActive = true, IsDeleted = false },
            new Category { Id = 15, Name = "Kişisel Gelişim", IsActive = true, IsDeleted = false },
            new Category { Id = 16, Name = "Yemek", IsActive = true, IsDeleted = false },
            new Category { Id = 17, Name = "Hobi", IsActive = true, IsDeleted = false },
            new Category { Id = 18, Name = "Referans", IsActive = true, IsDeleted = false },
            new Category { Id = 19, Name = "Eğitim", IsActive = true, IsDeleted = false });

    }

}
