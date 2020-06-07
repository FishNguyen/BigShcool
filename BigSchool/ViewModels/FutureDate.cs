using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool.Models;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BigSchool.ViewModels
{
    public class FutureDate : Attribute
    {
        public  bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),"dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None
                ,out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}