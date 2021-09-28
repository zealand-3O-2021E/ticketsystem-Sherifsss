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
        [TestMethod]
        public void PriceTest()
        {
            MC mc = new MC("1234567", DateTime.Now);
            double actualValue = mc.Price();
            mc.Brobiz = false;
            Assert.AreEqual(125, actualValue);
        }

        [TestMethod]
        public void BrobizTest()
        {
            MC mc = new MC("1234567", DateTime.Now);
            mc.Brobiz = true;
            double actualValue = mc.Price();
            Assert.AreEqual(118.75,actualValue);
        }

        [TestMethod]
        public void VehicleTypeTest()
        {
            MC mc = new MC("1234567", DateTime.Now);
            string actualValue = mc.VehicleType();
            Assert.AreEqual("MC", actualValue);
        }
    }

}
