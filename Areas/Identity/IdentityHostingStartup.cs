using System;
using Flashcards.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Flashcards.Areas.Identity.IdentityHostingStartup))]
namespace Flashcards.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {

            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AppDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<AppDbContext>();
            });
        }
    }
}