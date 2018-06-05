using HomeDepot.CalculateOhmValue.Web.Models;
using HomeDepot.CalculateOhmValue.Web.Utilities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HomeDepot.CalculateOhmValue.Web.Controllers
{
    public class HomeController : Controller
    {
        private Svc.Interfaces.IOhmValueCalculator OhmValuCalculator;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateOhm(BandColorModel model)
        {
            int result;
            try
            {
                if (Convert.ToInt32(model.Band) == 3)
                {
                    OhmValuCalculator = new Svc.Calculate3BandOhmValue();
                }
                // Since the given interface is only supports 4 bands. Hence both 4 and 5 bands will have 
                // same behaviour as the tolerance cannot be passed
                else if (Convert.ToInt32(model.Band) == 4 || Convert.ToInt32(model.Band) == 5)
                {
                    OhmValuCalculator = new Svc.Calculate4BandOhmValue();
                }

                result = OhmValuCalculator.CalculateOhmValue(model.BandAColor, model.BandBColor, model.BandCColor, model.BandDColor);
            }
            catch (ValidationException ex)
            {
                this.ModelState.AddModelErrors(ex);
                return PartialView();
            }

            return PartialView(result);
        }
    }
}
