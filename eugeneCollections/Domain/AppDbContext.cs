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
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Comment> Comments { get; set; }
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

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = "2e7260d4-1372-412d-aadb-061d53bb1ec3",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty,
                State = "Active"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "453a9142b-6d96-44fe-b817-982b5528f922",
                UserId = "2e7260d4-1372-412d-aadb-061d53bb1ec3"
            });
            modelBuilder.Entity<Like>().HasKey(y=>new {y.UserId, y.CollectiionId });

            //modelBuilder.Entity<Theme>().Property(g => g.Id).IsRequired();
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Id=1,
                Name = "Коты",
                Description = "Данный набор поможет вам быстро создать коллекцию котов"

            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Id=2,
                Name = "Собаки",
                Description = "Данный набор поможет вам быстро создать коллекцию собак"
            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Id=3,
                Name = "Алкоголь",
                Description = "Данный набор поможет вам быстро создать коллекцию алкогольных напитков"

            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Id=4,
                Name = "Цветы",
                Description = "Данный набор поможет вам быстро создать коллекцию цветов"

            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Id=5,
                Name = "Книги",
                Description = "Данный набор поможет вам быстро создать коллекцию книг"

            });
            modelBuilder.Entity<Theme>().HasData(new Theme
            {
                Id=6,
                Name = "Автомобили",
                Description = "Данный набор поможет вам быстро создать коллекцию автомобилей"

            });
            
        }
    }

}
