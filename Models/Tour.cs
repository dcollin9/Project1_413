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
        public string Day { get; set; }
        public string Time { get; set; }
        public string GroupName { get; set; }
        public int GroupSize { get; set; }
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber), RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
         ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNum { get; set; }
    }
}
