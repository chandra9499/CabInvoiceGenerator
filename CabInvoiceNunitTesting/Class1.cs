﻿using CabInvoiceGenerator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}