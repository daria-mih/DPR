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
            throw new NotImplementedException();
        }

        public IPhone createPhone()
        {
            throw new NotImplementedException();
        }

        public ITablet createTablet()
        {
            throw new NotImplementedException();
        }
    }
    class AppleFactory : AbstractFactory
    {
        public IPhablet createPhablet()
        {
            throw new NotImplementedException();
        }

        public IPhone createPhone()
        {
            throw new NotImplementedException();
        }

        public ITablet createTablet()
        {
            throw new NotImplementedException();
        }
    }
    class NokiaFactory : AbstractFactory
    {
        public IPhablet createPhablet()
        {
            throw new NotImplementedException();
        }

        public IPhone createPhone()
        {
            throw new NotImplementedException();
        }

        public ITablet createTablet()
        {
            throw new NotImplementedException();
        }
    }
}
