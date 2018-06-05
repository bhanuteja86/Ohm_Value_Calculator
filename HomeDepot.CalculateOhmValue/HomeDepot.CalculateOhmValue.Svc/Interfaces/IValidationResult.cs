using System.Collections.Generic;

namespace HomeDepot.CalculateOhmValue.Svc.Interfaces
{
    public interface IValidationResult
    {
        bool IsValid { get; }
        Dictionary<object, object> ErrorMessages { get; set; }
    }
}
