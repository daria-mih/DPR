using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Off : Command
    {
        Device device;
        public Off(Device d)
        {
            device = d;
        }
        public void execute()
        {
            device.off();
        }
        public void undo()
        {
            device.on();
        }
    }
}
