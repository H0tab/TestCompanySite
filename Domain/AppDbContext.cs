using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompanySite2.Domain.Entities;

namespace MyCompanySite2.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServieItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "b6bec49c-7503-4b41-9c79-b0163c829223",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "company@mail.ru",
                NormalizedEmail = "COMPANY@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "eab9e247-4f9c-48b6-aa52-f75f0b2fa57f",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "eab9e247-4f9c-48b6-aa52-f75f0b2fa57f",
                UserId = "b6bec49c-7503-4b41-9c79-b0163c829223"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4b77f8a6-ed03-4cd9-be6d-9dd82d8bcb30"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4cdeb593-ed26-4171-a746-931863b8c753"),
                CodeWord = "PageServices",
                Title = "Сервисы"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("808e4477-ac57-474c-beb6-b29f0ee26b26"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
