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
        private static List<Tour> appointment = new List<Tour>();
        public static IEnumerable<Tour> Appointment => appointment;
        public static void AddTime(Tour application)
        {
            appointment.Add(application);
        }
        public static void RemoveTime(Tour application)
        {
            appointment.Remove(application);
        }
    }
}
