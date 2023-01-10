﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFLoadings.EagerLoading;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
    {
        dbContextOptions.UseSqlite("Data source=user.db")
            .LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            Name = "Sardor",
            AddressId = 1,
        });

        modelBuilder.Entity<Address>().HasData(new Address
        {
            Id = 1,
            AddressName = "Farg'ona Buvayda Yangiqishloq",
        });
        
        modelBuilder.Entity<Contact>().HasData(new Contact[]
        {
            new Contact()
            {
                Id = 1,
                Phone = "+998912040618",
                UserId = 1,
            },
            new Contact()
            {
                Id = 2,
                Phone = "+998912040618",
                UserId = 1,
            },
        });
    }
}
