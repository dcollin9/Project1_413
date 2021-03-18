using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Models
{
    //A public interface allows us to access all of the parts of the program that we need
    public interface ITourRepository
    {


        IQueryable<Tour> Tours { get; }
    }
}
