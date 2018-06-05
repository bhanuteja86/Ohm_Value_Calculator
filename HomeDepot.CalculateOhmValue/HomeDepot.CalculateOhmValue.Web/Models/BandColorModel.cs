using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeDepot.CalculateOhmValue.Web.Models
{
    public class BandColorModel
    {
        public string BandAColor { get; set; }
        public string BandBColor { get; set; }
        public string BandCColor { get; set; }
        public string BandDColor { get; set; }
        public int result { get; set; }
        public int Band { get; set; }
    }
}