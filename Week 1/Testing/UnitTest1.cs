using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //testing FCFS
        public void TestFCFS()
        {
            BindingList<int> processes = new BindingList<int>
            {
                3, 27, 18, 60, 45, 5
            };

            int current = 6;

            ProcessHandler ph = new ProcessHandler(new FCFS());
            for (int i = 0; i < processes.Count; i++ )
            {
                processes[i] = ph.PerformRun(current, processes);
            }
            
        }

        [TestMethod]
        //Testing SSTF
        public void TestSSTF()
        {
            BindingList<int> processes = new BindingList<int>
            {
                19, 17, 5, 12, 10
            };

            int current = 9;
            int expectedresult = 10; 

            ProcessHandler ph = new ProcessHandler(new SSTF());
            int result = ph.PerformRun(current, processes);
            Assert.AreEqual(expectedresult, result);
        }
    }
}
