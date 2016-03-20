using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoratorPattern2;

namespace UnitTestCameraShop
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCameras()
        {
            Order o = new PhotoCamera();
            Assert.AreEqual(1200, o.cost());

            Order order = new VideoCamera();
            Assert.AreEqual(1700, order.cost());
        }

        [TestMethod]
        public void TestDecorators()
        {
            Order o = new PhotoCamera();
            o = new Lens(o);
            Assert.AreEqual(o.cost(), 1799);
            o = new Filter(o);
            Assert.AreEqual(o.cost(), 1822.50);
            o = new Extender(o);
            Assert.AreEqual(o.cost(), 2251.50);

            Order order = new VideoCamera();
            order = new Lens(order);
            Assert.AreEqual(order.cost(), 2299);
            order = new Filter(order);
            Assert.AreEqual(order.cost(), 2322.50);
            order = new Extender(order);
            Assert.AreEqual(order.cost(), 2751.50);
        }

    }
}
