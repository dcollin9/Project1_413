using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Models
{
    public class ITourRepository
    {
        IQueryable<Tour> Tours { get; }
    }
}
