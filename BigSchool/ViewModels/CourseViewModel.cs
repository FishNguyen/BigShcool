﻿using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BigSchool.ViewModels;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        //[FutureDate]
        public string Date { get; set; }
        [Required]
        //[ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTIme()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date, Time));
        }
    }
}