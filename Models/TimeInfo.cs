using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Models
{
    public class TimeInfo
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            TourDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TourDbContext>();
            //Checks to see if a migration already exists
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            //If one does not we input this data into the table
            if (!context.Tours.Any())
            {
                context.Tours.AddRange(
                new Tour
                {
                    Day = "Monday",
                    Time = "8:00 AM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "9:00 AM",
                    Avail = false,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "10:00 AM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "11:00 AM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "12:00 PM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "1:00 PM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "2:00 PM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "3:00 PM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "4:00 PM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "5:00 PM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "6:00 PM",
                    Avail = true,

                },
                new Tour
                {
                    Day = "Monday",
                    Time = "7:00 PM",
                    Avail = true,

                }
                
                );
                context.SaveChanges();

            }
        }
    }
}


