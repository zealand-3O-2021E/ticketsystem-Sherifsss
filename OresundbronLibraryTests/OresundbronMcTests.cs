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
    public class OresundbronMcTests
    {
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void OresundbronMcTest()
        {
            OresundbronMc mc = new OresundbronMc("12345678", DateTime.Now);
            Assert.Fail();
        }

        [TestMethod()]
        public void PriceTest()
        {
            OresundbronMc mc = new OresundbronMc("1234567", DateTime.Now);
            double actualValue = mc.Price();
            Assert.AreEqual(210,actualValue);
        }

        [TestMethod]
        public void BrobizTest()
        {
            OresundbronMc mc = new OresundbronMc("1234", DateTime.Now);
            mc.Brobiz = true;
            double actualValue = mc.Price();
            Assert.AreEqual(73,actualValue);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            OresundbronMc mc = new OresundbronMc("1234567", DateTime.Now);
            string actualValue = mc.VehicleType();
            Assert.AreEqual("Oresundbron Mc", actualValue);
        }
    }
}