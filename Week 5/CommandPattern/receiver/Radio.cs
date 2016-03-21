using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Radio : Device
    {
        public int volume { get; private set; } = 10;
        public Status status { get; private set; }

        public void on()
        {
            status = Status.on;
        }
        public void off()
        {
            status = Status.off;
        }
        public void volumeUp()
        { if (volume < 30)
            volume++;
        }
        public void volumeDown()
        {  if (volume > 0)
            volume--;
        }
    }
}
