using System;
using System.Collections.Generic;
using System.Linq;
using Flashcards.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Flashcards.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<FlashcardFolder> FlashcardFolders { get; set; }
        public DbSet<Flashcard> Flashcards { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            

            //sets up conversion of applicationUser.FlashcardFolderIds to string for Dbstorage.
            var splitStringConverter = new ValueConverter<List<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }).ToList());
            builder.Entity<ApplicationUser>().Property(nameof(ApplicationUser.FlashcardFolderIds)).HasConversion(splitStringConverter);


            var folderId = "7ce6bcbf-cf85-4641-a34d-3b912f1a35ce";
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<FlashcardFolder>().HasData(new
            {
                
                Id = folderId,
                FolderName = "French Vocabulary",
                Description = "Folder with cards for practicing basic French vocabulary",
                Subject = "French"
            });

            builder.Entity<Flashcard>().HasData(
            new
            {
                FrontText = "dog",
                BackText = "le chien // la chienne",
                Id = "1",
                FlashcardFolderId = folderId
            },
            new
            {
                FrontText = "cat",
                BackText = "le chat // la chatte",
                Id = "2",
                FlashcardFolderId = folderId
            },
			new
			{
                FrontText = "bird",
                BackText = "l'oiseau",
                Id = "3",
                FlashcardFolderId = folderId
            },
            new
			{
                FrontText = "fish",
                BackText = "le poisson",
                Id = "4",
                FlashcardFolderId = folderId
            },
            new
			{
                FrontText = "rabbit",
                BackText = "le lapin // la lapine",
                Id = "5",
                FlashcardFolderId = folderId
            }
            );
            const string ADMIN_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e73";
            const string ROLE_ID = ADMIN_ID;
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            List<string> userFolderIds = new List<string> { folderId };
            var appUser = new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "jon@test.com",
                Email = "jon@test.com",
                NormalizedUserName = "JON@TEST.COM",
                NormalizedEmail = "JON@TEST.COM",
                SecurityStamp = "d3161c7d-0523-e4bd-d1f6-c1799e016a53",
                EmailConfirmed = true,
                FlashcardFolderIds = userFolderIds
            };

            var hasher = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = hasher.HashPassword(appUser, "Pie1122!");

            builder.Entity<ApplicationUser>().HasData(
                    appUser
                );
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });



        }
    }
}
