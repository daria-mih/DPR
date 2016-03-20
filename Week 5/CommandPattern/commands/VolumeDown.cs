using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class VolumeDown : Command
    {
        Device device;
        public VolumeDown(Device d)
        {
            device = d;
        }
        public void execute()
        {
            device.volumeDown();
        }
        public void undo()
        {
            device.volumeUp();
        }
    }
}
