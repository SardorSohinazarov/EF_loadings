using EFLoadings.EagerLoading;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFLoadings.LazyLoading;

public class UserLazyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Region> Regions { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
    {
        dbContextOptions
            .UseLazyLoadingProxies()
            .UseSqlite("Data source=user.db")
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

        modelBuilder.Entity<Region>().HasData(new Region[]
        {
                    new()
                    {
                        Id = 1,
                        Name = "Buvayda",
                        AddressId = 1
                    },
                    new()
                    {
                        Id = 2,
                        Name = "Uchko'prik",
                        AddressId = 1
                    },
        });

        modelBuilder.Entity<Address>().HasData(new Address
        {
            Id = 1,
            AddressName = "Farg'ona Buvayda Yangiqishloq",
        });

        modelBuilder.Entity<Provider>().HasData(new List<Provider>()
        {
            new Provider()
            {
                Id = 1,
                Name = "Beeline",
            },
            new Provider()
            {
                Id = 2,
                Name = "Ucell"
            }
        });

        modelBuilder.Entity<Contact>().HasData(new Contact[]
        {
            new Contact()
            {
                Id = 1,
                Phone = "+998912040618",
                UserId = 1,
                ProviderId = 1,
            },
            new Contact()
            {
                Id = 2,
                Phone = "+998912040618",
                UserId = 1,
                ProviderId = 2
            },
        });
    }
}
