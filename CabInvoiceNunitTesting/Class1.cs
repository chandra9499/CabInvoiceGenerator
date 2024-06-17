using CabInvoiceGenerator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceNunitTesting
{
    [TestFixture]
    public class Class1
    {
        [TestCase(2.0, 20.0, 20.0)]
        [TestCase(4.0, 40.0, 80.0)]
        public void calculateFareTesting(double distance, double time, double expected) {
            ICabInvoice cabInvoice = new CabInvoiceImpl();
            double actuval = cabInvoice.calculateFare(distance, time);
            Assert.AreEqual(expected, actuval);
        }
        [TestCase(3.0, 20.0, 45.0)]
        [TestCase(5.0, 40.0, 155.0)]
        public void calculateFareForPremiumTesting(double distance, double time, double expected)
        {
            ICabInvoice cabInvoice = new CabInvoiceImpl();
            double actuval = cabInvoice.calculateFareForPremium(distance, time);
            Assert.AreEqual(expected, actuval);
        }
        [TestCase(2,new double[]{ 2.0,4.0}, new double[] { 20.0,40.0},100.0)]
        public void multipleRidesTesting(int rides,double[] distance, double[] time, double expected)
        {
            ICabInvoice cabInvoice = new CabInvoiceImpl();
            double actuval = cabInvoice.multipleRides(rides,distance, time);
            Assert.AreEqual(expected, actuval);
        }
        [Test]
        [TestCase(2, new double[] { 2.0, 4.0 }, new double[] { 20.0, 40.0 }, "-Total Number Of Rides :- 2 -TotalFare :- 100 -Average Fare Price :-50")]
        public void totalInvoiceGeneratorTesting(int rides, double[] distance, double[] time, string expected)
        {
            ICabInvoice cabInvoice = new CabInvoiceImpl();
            string actual = cabInvoice.totalInvoiceGenerator(rides, distance, time);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(101,"-Total Number Of Rides :- 2 -TotalFare :- 200 -Average Fare Price :-100")]
        public void invoiceServiceTesting(int userId,string expected)
        {
            ICabInvoice cabInvoice = new CabInvoiceImpl();
            string actual = cabInvoice.invoiceService(userId);
            Assert.AreEqual(expected, actual);
        }

    }
}
