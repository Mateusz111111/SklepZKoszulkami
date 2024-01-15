using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SklepZKoszulkami.Models;

namespace SklepZKoszulkami.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "BarcelonaFootballJersey",
                    Description = "Description",
                    Club = "FC Barcelona",
                    Brand = "Nike",
                    Size = "XL",
                    Price = 345,
                    Season = "2023/24",
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "ManCityFootballJersey",
                    Description = "Description",
                    Club = "Manchester City",
                    Brand = "Puma",
                    Size = "L",
                    Price = 349,
                    Season = "2023/24",
                    ImageUrl = ""
                });
        }



    }
}
