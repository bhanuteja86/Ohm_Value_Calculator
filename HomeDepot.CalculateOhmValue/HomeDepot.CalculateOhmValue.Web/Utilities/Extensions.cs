using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;

namespace HomeDepot.CalculateOhmValue.Web.Utilities
{
    public static class MvcValidationExtension
    {
        public static void AddModelErrors(this ModelStateDictionary state, 
       ValidationException exception)
        {
            foreach (var msg in exception.Data.Keys)
            {
                state.AddModelError(msg.ToString(), exception.Data[msg].ToString());
            }
        }
    }
}