using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class VolumeUp : Command
    {
        Device device;
        public VolumeUp(Device d)
        {
            device = d;
        }
        public void execute()
        {
            device.volumeUp();
        }
        public void undo()
        {
            device.volumeDown();
        }
    }
}
