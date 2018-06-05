using System.Collections.Generic;

namespace HomeDepot.CalculateOhmValue.Svc
{
    public class Constants
    {
        static internal Dictionary<string, int> BandAColor = new Dictionary<string, int> { { "brown", 1 }, { "red", 2 }, { "orange", 3 }
            , { "yellow", 4 }, { "green", 5 }, { "blue", 6 }, { "violet", 7 }, { "gray", 8 }, { "white" , 9 } };
        static internal Dictionary<string, int> BandBCColor = new Dictionary<string, int> { { "black", 0 }, { "brown", 1 }
            , { "red", 2 }, { "orange", 3 }, { "yellow", 4 }, { "green", 5 }, { "blue", 6 }, { "violet", 7 }, { "gray", 8 }, { "white" , 9 } };
        static internal Dictionary<string, decimal> BandDColor = new Dictionary<string, decimal> { { "black", 1 }, { "brown", 10 },
            { "red", 100 }, { "orange", 1000 }, { "yellow", 10000 }, { "green",100000 }, { "blue",1000000 },{ "violet", 10000000 }, { "gray",100000000 },
            { "white", 1000000000 }, { "gold", 0.1m }, { "silver", 0.01m } };
        internal const string BandAColorValidationMsg = "invalid bandAColor color";
        internal const string BandBColorValidationMsg = "invalid bandBColor color";
        internal const string BandCColorValidationMsg = "invalid bandCColor color";
        internal const string BandDColorValidationMsg = "invalid bandDColor color";
    }
}
