using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Models.ViewModels
{
    public class TourListViewModel
    {

        //makes it so our program can enumerate through all of the Tour objects
        public IEnumerable<Tour> Tours { get; set; }
        
    }
}
