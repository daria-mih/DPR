using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    //Samsung products
    class GalaxyNote : IPhablet
    {
        public void Call()
        {
            throw new NotImplementedException();
        }

        public void PlayVideo()
        {
            throw new NotImplementedException();
        }
    }
    class GalaxyMini : IPhone
    {
        public void Call()
        {
            throw new NotImplementedException();
        }

        public void Message()
        {
            throw new NotImplementedException();
        }
    }
    class GalaxyTab : ITablet
    {
        public void PlayVideoHD()
        {
            throw new NotImplementedException();
        }
    }

    //AppleProducts

    class iPhone : IPhone
    {
        public void Call()
        {
            throw new NotImplementedException();
        }

        public void Message()
        {
            throw new NotImplementedException();
        }
    }

    class iPad : ITablet
    {
        public void PlayVideoHD()
        {
            throw new NotImplementedException();
        }
    }

    class iPhonePlus : IPhablet
    {
        public void Call()
        {
            throw new NotImplementedException();
        }

        public void PlayVideo()
        {
            throw new NotImplementedException();
        }
    }

    //Nokia

    class Lumia : IPhone
    {
        public void Call()
        {
            throw new NotImplementedException();
        }

        public void Message()
        {
            throw new NotImplementedException();
        }
    }

    class Lumia1520 : IPhablet
    {
        public void Call()
        {
            throw new NotImplementedException();
        }

        public void PlayVideo()
        {
            throw new NotImplementedException();
        }
    }

    class NokiaN1 : ITablet
    {
        public void PlayVideoHD()
        {
            throw new NotImplementedException();
        }
    }



}

