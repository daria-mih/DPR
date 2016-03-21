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

        [TestMethod]
        public void TestTVOn()
        {
            Device device = new Television();
            Command command = new On(device);
            DeviceButton button = new DeviceButton(command);
            button.press();
            Assert.AreEqual(device.status, Status.on);
        }

        [TestMethod]
        public void TestTVOff()
        {
            Device device = new Television();
            Command command = new Off(device);
            DeviceButton button = new DeviceButton(command);
            button.press();
            button.press();
            Assert.AreEqual(device.status, Status.off);
        }

        [TestMethod]
        public void TestRadioOn()
        {
            Device device = new Radio();
            Command command = new On(device);
            DeviceButton button = new DeviceButton(command);
            button.press();
            Assert.AreEqual(device.status, Status.on);
        }

        [TestMethod]
        public void TestRadioOff()
        {
            Device device = new Radio();
            Command command = new Off(device);
            DeviceButton button = new DeviceButton(command);
            button.press();
            button.press();
            Assert.AreEqual(device.status, Status.off);
        }

        [TestMethod]
        public void TestUndo()
        {
            Device device = new Radio();
            Command command = new On(device);
            DeviceButton button = new DeviceButton(command);
            button.press();
            Assert.AreEqual(device.status, Status.on);
            button.pressUndo();
            Assert.AreEqual(device.status, Status.off);

            Command c = new VolumeUp(device);
            DeviceButton b = new DeviceButton(c);
            b.press();
            Assert.AreEqual(11, device.volume);
            b.pressUndo();
            Assert.AreEqual(10, device.volume);
        }

    }
}
