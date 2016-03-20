using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Radio : Device
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
        {
            volume++;
        }
        public void volumeDown()
        {
            volume--;
        }
    }
}
