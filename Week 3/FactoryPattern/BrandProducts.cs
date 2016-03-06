using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPattern
{
    //Samsung products
    class GalaxyNote : IPhablet
    {
        public string Call()
        {
            return GetType().ToString() + " is calling";
        }

        public Bitmap ShowPictureSD()
        {
            return Properties.Resources.AppleLD;
        }
    }
    class GalaxyMini : IPhone
    {
        public string Call()
        {
            return GetType().ToString() + " is calling";
        }

        public Bitmap ShowPictureLD()
        {
            return Properties.Resources.SamsungLD;
        }
    }
    class GalaxyTab : ITablet
    {
        public Bitmap ShowPictureHD()
        {
            return Properties.Resources.SamsungHD;
        }
    }

    //AppleProducts

    class iPhone : IPhone
    {
        public string Call()
        {
            return GetType().ToString() + " is calling";
        }

        public Bitmap ShowPictureLD()
        {
            return Properties.Resources.AppleLD;
        }
    }

    class iPad : ITablet
    {
        public Bitmap ShowPictureHD()
        {
            return Properties.Resources.AppleHD;
        }
    }

    class iPhonePlus : IPhablet
    {
        public string Call()
        {
            return GetType().ToString() + " is calling";
        }

        public Bitmap ShowPictureSD()
        {
            return Properties.Resources.AppleSD;
        }
    }

    //Nokia

    class Lumia : IPhone
    {
        public string Call()
        {
            return GetType().ToString() + " is calling";
        }

        public Bitmap ShowPictureLD()
        {
            return Properties.Resources.NokiaLD;
        }
    }

    class LumiaPhab : IPhablet
    {
        public string Call()
        {
            return GetType().ToString() + " is calling";
        }

        public Bitmap ShowPictureSD()
        {
            return Properties.Resources.NokiaSD;
        }
    }

    class LumiaTab : ITablet
    {
        public Bitmap ShowPictureHD()
        {
            return Properties.Resources.NokiaHD;

        }
    }


}

