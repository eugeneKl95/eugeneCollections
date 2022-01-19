using eugeneCollections.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Like> Likes {get; set;}
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Theme> Themes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            IdentityRole admin = new IdentityRole() {
                Id = "453a9142b-6d96-44fe-b817-982b5528f922",
                Name = "admin",
                NormalizedName = "ADMIN"
            };
            IdentityRole user = new IdentityRole()
            {
                Id = "69fc5637-63fd-43e7-8e50-66ede650df4c",
                Name = "user",
                NormalizedName = "USER"
            };
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole[] { admin, user });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2e7260d4-1372-412d-aadb-061d53bb1ec3",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "453a9142b-6d96-44fe-b817-982b5528f922",
                UserId = "2e7260d4-1372-412d-aadb-061d53bb1ec3"
            });

            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Name = "Коты",
                Description = "Данный набор поможет вам быстро создать коллекцию котов"

            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Name = "Собаки",
                Description = "Данный набор поможет вам быстро создать коллекцию собак"
            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Name = "Алкоголь",
                Description = "Данный набор поможет вам быстро создать коллекцию алкогольных напитков"

            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Name = "Цветы",
                Description = "Данный набор поможет вам быстро создать коллекцию цветов"

            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Name = "Книги",
                Description = "Данный набор поможет вам быстро создать коллекцию книг"

            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Name = "Автомобили",
                Description = "Данный набор поможет вам быстро создать коллекцию автомобилей"

            });
            
        }
    }

}
