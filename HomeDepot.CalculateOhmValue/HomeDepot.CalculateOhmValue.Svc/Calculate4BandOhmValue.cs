using HomeDepot.CalculateOhmValue.Svc.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace HomeDepot.CalculateOhmValue.Svc
{
   public class Calculate4BandOhmValue : IOhmValueCalculator
    {
       private Svc.Validation.SvcValidationResult validationresult;

        public Calculate4BandOhmValue()
        {
            validationresult=new Validation.SvcValidationResult();
        }

       public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            if (!BandAColorValidator(bandAColor))
            {
                validationresult.ErrorMessages.Add("bandAColor", Constants.BandAColorValidationMsg);
            }
            if (!BandBCColorValidator(bandBColor))
            {
                validationresult.ErrorMessages.Add("bandBColor", Constants.BandBColorValidationMsg);
            }
            if (!BandBCColorValidator(bandCColor))
            {
                validationresult.ErrorMessages.Add("bandCColor", Constants.BandCColorValidationMsg);
            }
            if (!BandDColorValidator(bandDColor))
            {
                validationresult.ErrorMessages.Add("bandDColor", Constants.BandDColorValidationMsg);
            }

            if (!validationresult.IsValid)
            {
                ValidationException ex = new ValidationException();
                foreach (var msg in validationresult.ErrorMessages)
                {
                    ex.Data.Add(msg.Key, msg.Value);
                }
                throw ex;
            }

          return (Constants.BandAColor[bandAColor] * 100 + Constants.BandBCColor[bandBColor] * 10 + Constants.BandBCColor[bandCColor]) *  Convert.ToInt32(Constants.BandDColor[bandDColor]);
        }

       /// <summary>
       /// Validation for bandA
       /// </summary>
       /// <param name="bandAColor"></param>
       /// <returns></returns>
       protected bool BandAColorValidator(string bandAColor)
       {
           return bandAColor != null && Constants.BandAColor.ContainsKey(bandAColor);
       }

       protected bool BandBCColorValidator(string Color)
       {
           return Color != null && Constants.BandBCColor.ContainsKey(Color);
       }

       protected bool BandDColorValidator(string bandDColor)
       {
           return bandDColor != null && Constants.BandDColor.ContainsKey(bandDColor);
       }
    }
}
