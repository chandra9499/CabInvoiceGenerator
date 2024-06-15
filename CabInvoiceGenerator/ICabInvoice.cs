using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public interface ICabInvoice
    {
        double calculateFare(double distace, double time);
    }
}
