using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.Models
{
    public class Attendance
    {
        public Course Course { get; set; }
        [Key]
        [Column(Oder =1)]
        public applicationUser Attendee { get; set; }
        [Key]
        [Column(Oder = 2)]
        public string AttendeeID { get; set; }
    }
}