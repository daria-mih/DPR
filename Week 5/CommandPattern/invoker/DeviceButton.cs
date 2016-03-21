using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DeviceButton
    {
        Command c;
        public DeviceButton(Command c)
        {
            this.c = c;
        }
        public void press()
        {
            c.execute();
        }
        public void pressUndo()
        {
            c.undo();
        }
    }
}
