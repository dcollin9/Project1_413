using Group1_7_Project1_IS413.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Models
{
    public class ModelMix
    {
        public IEnumerable<Tour> ToursObject { get; set; }
        public IEnumerable<TimeInfo> TimeInfoObjects { get; set; }
    }
}
