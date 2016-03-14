using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WattCalculator;

namespace UnitTests
{
    [TestClass]
    public class DecoratorTests
    {
        [TestMethod]
        public void TestComponents()
        {
            IWattCalculator test = new ArduinoUno();
            Assert.AreEqual(21.40, test.Measure());
            test = new ArduinoDuo();
            Assert.AreNotEqual(21.40, test.Measure());
            Assert.AreEqual(27.43, test.Measure());
            test = new Breadboard();
            Assert.AreNotEqual(27.43, test.Measure());
            Assert.AreEqual(3.50, test.Measure());
        }

        [TestMethod]
        public void TestBuzzer()
        {
            IWattCalculator test = new Breadboard();
            Assert.AreEqual(3.50, test.Measure());
            test = new Buzzer(test);
            Assert.AreEqual(8.91, test.Measure() - 3.50);
        }
        [TestMethod]
        public void TestLED()
        {
            IWattCalculator test = new Breadboard();
            Assert.AreEqual(3.50, test.Measure());
            test = new LED(test);
            Assert.AreEqual(12.36, test.Measure() - 3.50);
        }
        [TestMethod]
        public void TestResistor()
        {
            IWattCalculator test = new Breadboard();
            Assert.AreEqual(3.50, test.Measure());
            test = new Resistor(test);
            Assert.AreEqual(17.24, test.Measure() - 3.50);
        }
        [TestMethod]
        public void TestRGBLED()
        {
            IWattCalculator test = new Breadboard();
            Assert.AreEqual(3.50, test.Measure());
            test = new RGBLED(test);
            Assert.AreEqual(15.48, test.Measure() - 3.50);
        }
        [TestMethod]
        public void TestComplicated()
        {
            double testWatts;
            IWattCalculator test = new ArduinoUno();
            Assert.AreEqual(21.40, test.Measure());
            testWatts = test.Measure();
            test = new RGBLED(test);
            Assert.AreEqual(testWatts + 15.48, test.Measure());
            testWatts = test.Measure();
            test = new Buzzer(test);
            Assert.AreEqual(testWatts + 8.91, test.Measure());
            testWatts = test.Measure();
            test = new Resistor(test);
            Assert.AreEqual(testWatts + 17.24, test.Measure());
            testWatts = test.Measure();
            test = new LED(test);
            Assert.AreEqual(testWatts + 12.36, test.Measure());

        }


    }
}
