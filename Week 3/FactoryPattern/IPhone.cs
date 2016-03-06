﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace FactoryPattern
{
    public interface IPhone
    {
        SoundPlayer Call();
        Bitmap ShowPictureLD();
    }
}
