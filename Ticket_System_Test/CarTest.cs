using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;

namespace Ticket_System_Test
{
    [TestClass]
    public class CarTest
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CarLicensePlateTest()
        {
            Car c = new Car("12345678", DateTime.Now);
            Assert.Fail();
        }

        [TestMethod]
        public void PriceTest()
        {
            Car c = new Car("1234567", DateTime.Now);
            c.Brobiz = false;
            double actualValue = c.Price();
            Assert.AreEqual(240, actualValue);
        }

        [TestMethod]
        public void BrobizTest()
        {

            Car c = new Car("1234567", DateTime.Now);
            c.Brobiz = true;
            double actualValue = c.Price();           
            Assert.AreEqual(228, actualValue);
        }

        [TestMethod]
        public void VehicleTypeTest()
        {
            Car c = new Car("1234567", DateTime.Now);
            string actualValue = c.VehicleType();
            Assert.AreEqual("Car", actualValue);
        }

    }
}
