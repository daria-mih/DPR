using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandPattern;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVolumeUpTV()
        {
            int expected = 35;

            Device device = new Television();
            Command command = new VolumeUp(device);
            DeviceButton button = new DeviceButton(command);
            for (int i =0; i <25; i++)
            {
                button.press();
            }

            Assert.AreEqual(expected, device.volume);

        }

        [TestMethod]
        public void TestVolumeDownTV()
        {
            int expected = 5;

            Device device = new Television();
            Command command = new VolumeDown(device);
            DeviceButton button = new DeviceButton(command);
            for (int i = 0; i < 5; i++)
            {
                button.press();
            }

            Assert.AreEqual(expected, device.volume);
        }

        [TestMethod]
        public void TestVolumeUpRadio()
        {
            int expected = 23;

            Device device = new Radio();
            Command command = new VolumeUp(device);
            DeviceButton button = new DeviceButton(command);
            for (int i = 0; i < 13; i++)
            {
                button.press();
            }

            Assert.AreEqual(expected, device.volume);

        }

        [TestMethod]
        public void TestVolumeDownRadio()
        {
            int expected = 4;

            Device device = new Radio();
            Command command = new VolumeDown(device);
            DeviceButton button = new DeviceButton(command);
            for (int i = 0; i < 6; i++)
            {
                button.press();
            }

            Assert.AreEqual(expected, device.volume);
        }

        public void TestTVOn()
        {

        }
    }
}
