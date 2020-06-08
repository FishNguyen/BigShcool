using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using BigSchool.Models;

namespace BigSchool.DTOs
{
    public class AttendanceDto
    {
        public int CourseId { get; set; }
    }
}