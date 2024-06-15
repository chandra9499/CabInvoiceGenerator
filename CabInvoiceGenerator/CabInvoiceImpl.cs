using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceImpl : ICabInvoice
    {
        private const double costPerKilometer = 10.0;
        private const double costPerMinute = 1.0;
        private const double minFare = 5.0;
        public double calculateFare(double distace, double time)
        {
            double totalFare = (time < 30)? (distace * costPerKilometer): (distace * costPerKilometer) + (time * costPerMinute);
            return (totalFare < minFare) ? minFare : totalFare;               
        }
    }
}
