using HomeDepot.CalculateOhmValue.Svc.Interfaces;
using System.Collections.Generic;

namespace HomeDepot.CalculateOhmValue.Svc.Validation
{
    public class SvcValidationResult : IValidationResult
    {
        public Dictionary<object, object> ErrorMessages { get; set; }

        public bool IsValid
        {
            get
            {
                return ErrorMessages.Count == 0;
            }
        }
        public SvcValidationResult()
        {
            ErrorMessages = new Dictionary<object, object>();
        }
    }
}
