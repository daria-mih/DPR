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
    class GalaxyMini:IPhone
    {
    }
    class GalaxyTab:ITablet
    {
    }
}
