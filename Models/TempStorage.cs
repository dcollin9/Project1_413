using Group1_7_Project1_IS413.Models;
using Group1_7_Project1_IS413.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Models
{
    public class TempStorage
    {
        private static List<TimeInfo> times = new List<TimeInfo>();
        public static IEnumerable<TimeInfo> Times => times;
        public static void AddTime(TimeInfo application)
        {
            times.Add(application);
        }
    }
}
