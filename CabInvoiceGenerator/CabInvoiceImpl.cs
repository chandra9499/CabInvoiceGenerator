using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
        public double multipleRides(int rides,double[] distace, double[] time)
        {
            double totalCost = 0;
            int i = 0;
            while(i<rides)
            {
                totalCost += calculateFare(distace[i], time[i]);
                 i++;
            }
            return totalCost;
        }
        public string totalInvoiceGenerator(int rides, double[] distace, double[] time)
        {
            double totalCost = 0;
            int i = 0;
            while (i < rides)
            {
                totalCost += calculateFare(distace[i], time[i]);
                i++;
            }
            return $"-Total Number Of Rides :- {rides} -TotalFare :- {totalCost} -Average Fare Price :-{totalCost/rides}";
        }

        public string invoiceService(int userId)
        {
            List<Rides> invoice= new List<Rides>();
            invoice.Add(new Rides(101, new double[] { 10.0, 10.0 }, new double[] { 6.0, 5.0 }, 2));
            invoice.Add(new Rides(102, new double[] { 11.0, 15.0,10.0 }, new double[] { 16.0, 15.0,11.0 }, 3));

            foreach(Rides ride in invoice)
            {
                if(userId ==ride.userId)    
                 return totalInvoiceGenerator(ride.noOfrides, ride.distance, ride.time);
            }
            return null;
        }
    }
}
