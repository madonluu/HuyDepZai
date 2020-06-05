using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuuKhanhHuy_lab456.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime datatime;
            var IsValid = DateTime.TryParseExact(Convert.ToString(value)),
                "dd/M/yyyy",
            CultureInfo
            return base.IsValid(value);
        }
    }
}