using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Locatronics;
using System.Collections.Generic;

namespace tests
{
    [TestClass]
    public class PreviewTests
    {
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
