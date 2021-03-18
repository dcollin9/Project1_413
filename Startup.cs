using Group1_7_Project1_IS413.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Group1_7_Project1_IS413.Models.ViewModels;

namespace Group1_7_Project1_IS413
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<TourDbContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:TourConnection"]);
            });
            services.AddScoped<ITourRepository, EFTourRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //this endpoint takes the user to the Signups page when the user types the word "signups"
                endpoints.MapControllerRoute("Signups",
                "signups",
                new { Controller = "Home", action = "Signups", method = "HttpGet" });

                //this endpoint takes the user to the ViewAppointments page when the user types the word "appointments"
                endpoints.MapControllerRoute("ViewAppointments",
                "appointments",
                new { Controller = "Home", action = "ViewAppointments" });


            });

            //seeds the database upon startup if one is not already selected
            TimeInfo.EnsurePopulated(app);
        }

    }
}
