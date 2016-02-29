using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern;
using System.Collections.Generic;

namespace UnitTestPush
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
        public void TestYearObserver()
        {
            PersonRegister pr = new PersonRegister();
            IObserverPush o = new YearObserver(pr);
            pr.p.GrowUp();
            List<IObserverPush> observers = new List<IObserverPush>();
            pr.Attach(o);
            pr.Notify();
            int expectedresult = 1;
            Assert.AreEqual(expectedresult, o.ToForm());
            
        }
        [TestMethod]
        public void TestMonthObserver()
        {
            PersonRegister pr = new PersonRegister();
            IObserverPush o = new MonthObserver(pr);
            pr.p.GrowUp();
            pr.p.GrowUp();
            pr.p.GrowUp();
            List<IObserverPush> observers = new List<IObserverPush>();
            pr.Attach(o);
            pr.Notify();
            int expectedresult = 36;
            Assert.AreEqual(expectedresult, o.ToForm());
        }
        [TestMethod]
        public void TestDayObserver()
        {
            PersonRegister pr = new PersonRegister();
            IObserverPush o = new DayObserver(pr);
            pr.p.GrowUp();
            pr.p.GrowUp();
            pr.p.GrowUp();
            List<IObserverPush> observers = new List<IObserverPush>();
            pr.Attach(o);
            pr.Notify();
            int expectedresult = 1095;
            Assert.AreEqual(expectedresult, o.ToForm());
        }
        [TestMethod]
        public void TestHeightObserver()
        {
            PersonRegister pr = new PersonRegister();
            IObserverPush o = new HeightObserver(pr);
            pr.p.GrowUp();
            pr.p.GrowUp();
            pr.p.GrowUp();
            List<IObserverPush> observers = new List<IObserverPush>();
            pr.Attach(o);
            pr.Notify();
            int expectedresult = 6;
            Assert.AreEqual(expectedresult, o.ToForm());
        }
    }
}
