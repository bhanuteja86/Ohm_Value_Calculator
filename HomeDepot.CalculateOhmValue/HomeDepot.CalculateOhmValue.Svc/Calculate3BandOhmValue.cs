using HomeDepot.CalculateOhmValue.Svc.Interfaces;
using HomeDepot.CalculateOhmValue.Svc.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace HomeDepot.CalculateOhmValue.Svc
{
    public class Calculate3BandOhmValue : IOhmValueCalculator
    {
        private SvcValidationResult validationresult;

        public Calculate3BandOhmValue()
        {
            validationresult = new SvcValidationResult();
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

            return (Constants.BandAColor[bandAColor] * 10 + Constants.BandBCColor[bandBColor]) * Convert.ToInt32(Constants.BandDColor[bandDColor]);
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
