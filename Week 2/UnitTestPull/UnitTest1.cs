using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern;
using System.Collections.Generic;

namespace UnitTestPull
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGrowUp()
        {
            Person p = new Person("Dasha", 50);
            int expectedage = 1;
            int expectedheight = 52;
            p.GrowUp();
            Assert.AreEqual(expectedage, p.age);
            Assert.AreEqual(expectedheight, p.height);
        }

        [TestMethod]
        public void TestGetAge()
        {
            int expectedage = 0;
            PersonRegister pr = new PersonRegister();
            Assert.AreEqual(pr.GetAge(), expectedage);
        }

        [TestMethod]
        public void TestGetHeight()
        {
            int expectedheight = 0;
            PersonRegister pr = new PersonRegister();
            Assert.AreEqual(pr.GetHeight(), expectedheight);
        }
        [TestMethod]
        public void TestDayObserver()
        {
            List<IObserverPull> observers = new List<IObserverPull>();
            PersonRegister pr = new PersonRegister();
            IObserverPull dayob = new DayObserver(pr);
            pr.p.GrowUp();
            pr.p.GrowUp(); 
            int expectedresult = 730;
            pr.Notify();
            Assert.AreEqual(expectedresult, dayob.ToForm());

        }

        [TestMethod]
        public void TestMonthObserver()
        {
            List<IObserverPull> observers = new List<IObserverPull>();
            PersonRegister pr = new PersonRegister();
            IObserverPull mnthob = new MonthObserver(pr);
            pr.p.GrowUp();
            pr.p.GrowUp();
            int expectedresult = 24;
            pr.Notify();
            Assert.AreEqual(expectedresult, mnthob.ToForm());
        }

        [TestMethod]
        public void TestYearObserver()
        {
            List<IObserverPull> observers = new List<IObserverPull>();
            PersonRegister pr = new PersonRegister();
            IObserverPull yearob = new YearObserver(pr);
            pr.p.GrowUp();
            pr.p.GrowUp();
            int expectedresult = 2;
            pr.Notify();
            Assert.AreEqual(expectedresult, yearob.ToForm());
        }

        [TestMethod]
        public void TestHeightObserver()
        {
            List<IObserverPull> observers = new List<IObserverPull>();
            PersonRegister pr = new PersonRegister();
            IObserverPull heightob = new HeightObserver(pr);
            pr.p.GrowUp();
            pr.p.GrowUp();
            int expectedresult = 4;
            pr.Notify();
            Assert.AreEqual(expectedresult, heightob.ToForm());

        }
    }

}
