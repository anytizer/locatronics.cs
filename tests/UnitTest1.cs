using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Locatronics;
using System.Collections.Generic;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void search_1N4007()
        {
            // search the basket contents
            // find the address
            // glow address rack
            organizer o = new organizer();

            int requiredAddress = 29;
            string component = "1n4007";
            List<baskets> search = o.search(component);
            Assert.AreEqual(search.Count, 1);

            Assert.AreEqual(search[0].location.address, requiredAddress);
        }

        [TestMethod]
        public void search_Capacitors()
        {
            // search the basket contents
            // find the address
            // glow address rack
            organizer o = new organizer();

            int requiredAddress = 41;
            string component = "capacitor";
            List<baskets> search = o.search(component);
            Assert.AreEqual(search.Count, 3);

            // 41, 42, 43
            Assert.AreEqual(search[0].location.address, requiredAddress);
        }

        [TestMethod]
        public void search_gpio()
        {
            organizer o = new organizer();

            int requiredAddress = 75;
            string component = "gpio";
            List<baskets> search = o.search(component);

            Assert.AreEqual(search.Count, 1);
            Assert.AreEqual(search[0].location.address, requiredAddress);
        }

        [TestMethod]
        public void preview_Capacitors()
        {
            organizer o = new organizer();

            string component = "capacitor";
            List<string> names = o.preview(component);
            Assert.AreEqual(names.Count, 3);
        }
    }
}
