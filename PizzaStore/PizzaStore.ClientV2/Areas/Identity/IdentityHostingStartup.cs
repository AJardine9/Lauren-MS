using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaStore.ClientV2.Models;

[assembly: HostingStartup(typeof(PizzaStore.ClientV2.Areas.Identity.IdentityHostingStartup))]
namespace PizzaStore.ClientV2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PizzaStoreClientV2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PizzaStoreClientV2ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<PizzaStoreClientV2Context>();
            });
        }
    }
}