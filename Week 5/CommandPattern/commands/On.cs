using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class On : Command
    {
        Device device;
        public On(Device d)
        {
            device = d;
        }
        public void execute()
        {
            device.on();
        }
        public void undo()
        {
            device.off();
        }
    }
}
