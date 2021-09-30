using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;


namespace Ticket_System_Test
{
    [TestClass]
    public class McTest
    {
        ///<summary> A test method for testing the license plate length</summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void McLicensePlateTest()
        {
            MC mc = new MC("12345678", DateTime.Now);
            Assert.Fail();
        }
        /// <summary>
        /// a test method for testing the default price of the car which is 240
        /// </summary>
        [TestMethod]
        public void PriceTest_Is125()
        {
            MC mc = new MC("1234567", DateTime.Now);
            double actualValue = mc.Price();
            mc.Brobiz = false;
            Assert.AreEqual(125, actualValue);
        }
        /// <summary>
        /// A test method for testing the price with discount enabled
        /// </summary>
        [TestMethod]
        public void BrobizTest()
        {
            MC mc = new MC("1234567", DateTime.Now);
            mc.Brobiz = true;
            double actualValue = mc.Price();
            Assert.AreEqual(118.75,actualValue);
        }
        /// <summary>
        /// a test method for checking if the veichletype is the expected value
        /// </summary>
        [TestMethod]
        public void VehicleTypeTest()
        {
            MC mc = new MC("1234567", DateTime.Now);
            string actualValue = mc.VehicleType();
            Assert.AreEqual("MC", actualValue);
        }
    }

}
