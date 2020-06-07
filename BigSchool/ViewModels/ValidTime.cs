﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace BigSchool.ViewModels
{
    public class ValidTime : Attribute
    {
        public   bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None
                , out dateTime);
            return isValid;
        }
    }
}