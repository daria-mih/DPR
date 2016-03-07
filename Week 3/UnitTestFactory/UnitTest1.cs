using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryPattern;
using System.Media;
using System.Drawing;

namespace UnitTestFactory
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreatePhone()
        {
            GalaxyMini phone = new GalaxyMini();
            AbstractFactory samsung = new SamsungFactory();
            Assert.AreSame(phone.GetType(), samsung.createPhone().GetType());

            iPhone applephone = new iPhone();
            AbstractFactory apple = new AppleFactory();
            Assert.AreSame(applephone.GetType(), apple.createPhone().GetType());

            Lumia nokiaphone = new Lumia();
            AbstractFactory nokia = new NokiaFactory();
            Assert.AreSame(nokiaphone.GetType(), nokia.createPhone().GetType());
        }

        [TestMethod]
        public void TestCreateTablet()
        {
            iPad tablet = new iPad();
            AbstractFactory apple = new AppleFactory();
            Assert.AreSame(tablet.GetType(), apple.createTablet().GetType());

            LumiaTab nokiatablet = new LumiaTab();
            AbstractFactory nokia = new NokiaFactory();
            Assert.AreSame(nokiatablet.GetType(), nokia.createTablet().GetType());

            GalaxyTab samsungtablet = new GalaxyTab();
            AbstractFactory samsung = new SamsungFactory();
            Assert.AreSame(samsungtablet.GetType(), samsung.createTablet().GetType());


        }

        [TestMethod]
        public void TestCreatePhablet()
        {
            LumiaPhab phablet = new LumiaPhab();
            AbstractFactory nokia = new NokiaFactory();
            Assert.AreSame(phablet.GetType(), nokia.createPhablet().GetType());

            GalaxyNote samsungphablet = new GalaxyNote();
            AbstractFactory samsung = new SamsungFactory();
            Assert.AreSame(samsungphablet.GetType(), samsung.createPhablet().GetType());

            iPhonePlus applephablet = new iPhonePlus();
            AbstractFactory apple = new AppleFactory();
            Assert.AreSame(applephablet.GetType(), apple.createPhablet().GetType());


        }

        [TestMethod]
        public void TestCall()
        {
            AbstractFactory samsung = new SamsungFactory();
            IPhone phone = samsung.createPhone();
            IPhablet phablet = samsung.createPhablet();
            SoundPlayer sp = new SoundPlayer();
            Assert.AreSame(phone.Call().GetType(), sp.GetType());
            Assert.AreSame(phablet.Call().GetType(), sp.GetType());

            AbstractFactory nokia = new SamsungFactory();
            IPhone nokiaphone = nokia.createPhone();
            IPhablet nokiaphablet = nokia.createPhablet();
            Assert.AreSame(nokiaphone.Call().GetType(), sp.GetType());
            Assert.AreSame(nokiaphablet.Call().GetType(), sp.GetType());

            AbstractFactory apple = new SamsungFactory();
            IPhone applephone = apple.createPhone();
            IPhablet applephablet = apple.createPhablet();
            Assert.AreSame(applephone.Call().GetType(), sp.GetType());
            Assert.AreSame(applephablet.Call().GetType(), sp.GetType());


        }

       
    }
}
