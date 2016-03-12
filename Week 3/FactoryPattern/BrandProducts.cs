using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace FactoryPattern
{
    //Samsung products
   public class GalaxyNote : IPhablet
    {
        public SoundPlayer Call()
        {
            return new SoundPlayer(Properties.Resources.Samsung);
        }

        public Bitmap ShowPictureSD()
        {
            return Properties.Resources.AppleLD;
        }
    }
   public class GalaxyMini : IPhone
    {
        public SoundPlayer Call()
        {
            return new SoundPlayer(Properties.Resources.Samsung);
        }

        public Bitmap ShowPictureLD()
        {
            return Properties.Resources.SamsungLD;
        }
    }
    public class GalaxyTab : ITablet
    {
        public Bitmap ShowPictureHD()
        {
            return Properties.Resources.SamsungHD;
        }
    }

    //AppleProducts

    public class iPhone : IPhone
    {
        public SoundPlayer Call()
        {
            return new SoundPlayer(Properties.Resources.Apple);
        }

        public Bitmap ShowPictureLD()
        {
            return Properties.Resources.AppleLD;
        }
    }

    public class iPad : ITablet
    {
        public Bitmap ShowPictureHD()
        {
            return Properties.Resources.AppleHD;
        }
    }

    public class iPhonePlus : IPhablet
    {
        public SoundPlayer Call()
        {
            return new SoundPlayer(Properties.Resources.Apple);
        }

        public Bitmap ShowPictureSD()
        {
            return Properties.Resources.AppleSD;
        }
    }

    //Nokia

    public class Lumia : IPhone
    {
        public SoundPlayer Call()
        {
            return new SoundPlayer(Properties.Resources.Nokia);
        }

        public Bitmap ShowPictureLD()
        {
            return Properties.Resources.NokiaLD;
        }
    }

    public class LumiaPhab : IPhablet
    {
        public SoundPlayer Call()
        {
            return new SoundPlayer(Properties.Resources.Nokia);
        }

        public Bitmap ShowPictureSD()
        {
            return Properties.Resources.NokiaSD;
        }
    }

    public class LumiaTab : ITablet
    {
        public Bitmap ShowPictureHD()
        {
            return Properties.Resources.NokiaHD;

        }
    }


}

