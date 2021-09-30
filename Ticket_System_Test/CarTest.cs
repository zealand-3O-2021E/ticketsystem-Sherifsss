using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;

namespace Ticket_System_Test
{
    [TestClass]
    public class CarTest
    {
        [ExpectedException(typeof(ArgumentException))]

        ///<summary> A test method for testing the license plate length</summary>
        [TestMethod]
        public void CarLicensePlateTest()
        {
            Car c = new Car("12345678", DateTime.Now);
            Assert.Fail();
        }
        /// <summary>
        /// a test method for testing the default price of the car which is 240
        /// </summary>
        [TestMethod]
        public void PriceTest_Is240()
        {
            Car c = new Car("1234567", DateTime.Now);
            c.Brobiz = false;
            double actualValue = c.Price();
            Assert.AreEqual(240, actualValue);
        }
        /// <summary>
        /// A test method for testing the price with discount enabled
        /// </summary>
        [TestMethod]
        public void BrobizTest()
        {

            Car c = new Car("1234567", DateTime.Now);
            c.Brobiz = true;
            double actualValue = c.Price();
            Assert.AreEqual(228, actualValue);
        }
        /// <summary>
        /// a test method for checking if the veichletype is the expected value
        /// </summary>
        [TestMethod]
        public void VehicleTypeTest()
        {
            Car c = new Car("1234567", DateTime.Now);
            string actualValue = c.VehicleType();
            Assert.AreEqual("Car", actualValue);
        }

    }
}
