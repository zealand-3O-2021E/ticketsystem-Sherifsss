using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundbronLibrary.Tests
{

    [TestClass()]
    public class OresundbronCarTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void OresundbronCarTest()
        {
            OresundbronCar c = new OresundbronCar("12345678", DateTime.Now);
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            OresundbronCar c = new OresundbronCar("1234", DateTime.Now);
            double actualValue = c.Price();
            Assert.AreEqual(410, actualValue);
        }

        [TestMethod]
        public void BrobizTest()
        {
            OresundbronCar c = new OresundbronCar("1234", DateTime.Now);
            c.Brobiz = true;
            double actualValue = c.Price();
            Assert.AreEqual(161, actualValue);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            OresundbronCar c = new OresundbronCar("1234", DateTime.Now);
            string actualValue = c.VehicleType();
            Assert.AreEqual("Oresundbron car", actualValue);
        }
    }
}