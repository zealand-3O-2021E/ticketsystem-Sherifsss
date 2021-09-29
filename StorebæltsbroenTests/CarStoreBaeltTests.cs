using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class CarStoreBaeltTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void CarStoreBaeltTest()
        {
            CarStoreBaelt c = new CarStoreBaelt("12345678",DateTime.Now);
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            CarStoreBaelt c = new CarStoreBaelt("1234567", DateTime.Parse("25/09/2021"));
            c.Brobiz = true;
            double actualValue = c.Price();
            Assert.AreEqual(182.4, actualValue);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            CarStoreBaelt c = new CarStoreBaelt("1234567", DateTime.Now);
            string actualValue = c.VehicleType();
            Assert.AreEqual("Car", actualValue);
        }
    }
}