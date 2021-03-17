using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Group1_7_Project1_IS413.Models
{
    public class TourDbContext: DbContext
    {
        public TourDbContext(DbContextOptions<TourDbContext> options) : base(options)
        {

        }
        //sets the database to hold the projects
        public DbSet<Tour> Tours { get; set; }
        
    }
}
