using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrueCulture3.Data;

[assembly: HostingStartup(typeof(TrueCulture3.Areas.Identity.IdentityHostingStartup))]
namespace TrueCulture3.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TrueCulture3Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TrueCulture3ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TrueCulture3Context>();
            });
        }
    }
}