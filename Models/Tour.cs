using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group1_7_Project1_IS413.Models
{
    public class Tour
    {
        [Key, Required]
        public int TourId { get; set; }
        public bool Avail { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string GroupName { get; set; }
        public int GroupSize { get; set; }
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber), RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
         ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNum { get; set; }
        public static Tour[] GetTourInfos()
        {

            Tour T1 = new Tour
            {
                Day = "Monday",
                Time = "8:00 AM",
                Avail = true,

            };
            Tour T2 = new Tour
            {
                Day = "Monday",
                Time = "9:00 AM",
                Avail = true,

            };
            Tour T3 = new Tour
            {
                Day = "Monday",
                Time = "10:00 AM",
                Avail = true,

            };
            Tour T4 = new Tour
            {
                Day = "Monday",
                Time = "11:00 AM",
                Avail = true,

            };
            Tour T5 = new Tour
            {
                Day = "Monday",
                Time = "12:00 PM",
                Avail = true,

            };
            Tour T6 = new Tour
            {
                Day = "Monday",
                Time = "1:00 PM",
                Avail = true,

            };
            Tour T7 = new Tour
            {
                Day = "Monday",
                Time = "2:00 PM",
                Avail = true,

            };
            Tour T8 = new Tour
            {
                Day = "Monday",
                Time = "3:00 PM",
                Avail = true,

            };
            Tour T9 = new Tour
            {
                Day = "Monday",
                Time = "4:00 PM",
                Avail = true,

            };
            Tour T10 = new Tour
            {
                Day = "Monday",
                Time = "5:00 PM",
                Avail = true,

            };
            Tour T11 = new Tour
            {
                Day = "Monday",
                Time = "6:00 PM",
                Avail = true,

            };
            Tour T12 = new Tour
            {
                Day = "Monday",
                Time = "7:00 PM",
                Avail = true,

            };

            return new Tour[] { T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12 };
        }
    }
}
