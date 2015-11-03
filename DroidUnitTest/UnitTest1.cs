using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cis237assignment4;

namespace DroidUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTotalCostForProtocolWorks()
        {
            ProtocolDroid pdroid = new ProtocolDroid("Carbonite", "Protocol", "Bronze", 12);

            pdroid.CalculateTotalCost();

            Assert.AreEqual(450.00m, pdroid.TotalCost);
        }
    }
}
