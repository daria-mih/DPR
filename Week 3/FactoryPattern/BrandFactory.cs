using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class SamsungFactory : AbstractFactory
    {
        public IPhablet createPhablet()
        {
            return new GalaxyNote();
        }

        public IPhone createPhone()
        {
            return new GalaxyMini();
        }

        public ITablet createTablet()
        {
            return  new GalaxyTab();
        }
    }
    class AppleFactory : AbstractFactory
    {
        public IPhablet createPhablet()
        {
            return new iPhonePlus();
        }

        public IPhone createPhone()
        {
            return new iPhone();
        }

        public ITablet createTablet()
        {
            return new iPad();
        }
    }
    class NokiaFactory : AbstractFactory
    {
        public IPhablet createPhablet()
        {
            return new LumiaPhab();
        }

        public IPhone createPhone()
        {
            return new Lumia();
        }

        public ITablet createTablet()
        {
            return new LumiaTab();
        }
    }
}
