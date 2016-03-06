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
        public string Call()
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
        public string Call()
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
}
