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
        double multipleRides(int rides,double[] distace, double[] time);
        string totalInvoiceGenerator(int rides, double[] distace, double[] time);
        string invoiceService(int userId);
    }
}
