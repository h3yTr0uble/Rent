using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TransportReport
    {
        private double calculatedParam;
        public string TransportTitle { get; set; }
        public double CalculatedParam
        {
            get
            {
                return calculatedParam;
            }

            set
            {
                calculatedParam = Math.Round(value, 2);
            }
        }

        public TransportReport(string transportTitle, double calculatedParam)
        {
            TransportTitle = transportTitle;
            CalculatedParam = calculatedParam;
        }
    }
}
