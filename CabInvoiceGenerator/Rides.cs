using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Rides
    {
        public int userId { get; set; }

        public int noOfrides { get; set; }
        public double[] distance { get; set; }
        public double[] time { get; set;}

        public Rides(int userId, double[] distance, double[] time, int noOfrides)
        {
            this.userId = userId;
            this.distance = distance;
            this.time = time;
            this.noOfrides = noOfrides;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
