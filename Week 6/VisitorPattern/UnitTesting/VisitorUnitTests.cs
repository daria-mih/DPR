using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorPattern;

namespace UnitTesting
{
    [TestClass]
    public class VisitorUnitTests
    {
        [TestMethod]
        public void TestLocalPurchase()
        {
            int expected = 800;

            IVisitor local = new LocalPurchase();
            Phone phone = new Phone(300);
            Laptop laptop = new Laptop(500);

            Assert.AreEqual(expected, phone.accept(local) + laptop.accept(local));
        }


        [TestMethod]
        public void TestLocalSalePurchase()
        {
            double expected = 549.36;

            IVisitor local = new LocalSalePurchase();
            Phone phone = new Phone(366);
            Camera camera = new Camera(234);

            Assert.AreEqual(expected, phone.accept(local) + camera.accept(local));
        }


        [TestMethod]
        public void TestOnlinePurchase()
        {
            double expected = 855.55;

            IVisitor online = new OnlinePurchase();
            Phone phone = new Phone(100);
            Camera camera = new Camera(234);
            Laptop laptop = new Laptop(500);

            Assert.AreEqual(expected, phone.accept(online) + camera.accept(online) + laptop.accept(online));
        }

        [TestMethod]
        public void TestOnlineSalePurchase()
        {
            double expected = 2456.65;

            IVisitor online = new OnlineSalePurchase();
            Phone phone = new Phone(450);
            Camera camera = new Camera(950);
            Laptop laptop = new Laptop(1370);

            Assert.AreEqual(Math.Abs(expected), Math.Round(phone.accept(online) + camera.accept(online) + laptop.accept(online), 2));
        }
    }
}
