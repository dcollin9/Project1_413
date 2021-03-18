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

                    //data that will be used to seed the database
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 8,0,0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 9, 0,0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 10, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 11, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 12, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 13, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 14, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22,15, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 16, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 17, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 18, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 19, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 22, 20, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 8, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 9, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 10, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 11, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 12, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 13, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 14, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 15, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23,16, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 17, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 18, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 19, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 23, 20, 0, 0),
                    Avail = true,

                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 8, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 9, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 10, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 11, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 12, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 13, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 14, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 15, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 16, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 17, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 18, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 19, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 24, 20, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 8, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 9, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 10, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 11, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 12, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 13, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 14, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 15, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 16, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 17, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 18, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 19, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 25, 20, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 8, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 9, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 10, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 11, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 12, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 13, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 14, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 15, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 16, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 17, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 18, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 19, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 26, 20, 0, 0),
                    Avail = true,
                },
                new Tour { 
                DayTime = new DateTime(2021, 03, 27, 8, 0, 0),
                Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 9, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 10, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 11, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 12, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 13, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 14, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 15, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 16, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 17, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 18, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 19, 0, 0),
                    Avail = true,
                },
                new Tour
                {
                    DayTime = new DateTime(2021, 03, 27, 20, 0, 0),
                    Avail = true,
                }





                );
                context.SaveChanges();

            }
        }
    }
}


