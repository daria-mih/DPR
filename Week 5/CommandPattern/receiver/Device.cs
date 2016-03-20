using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface Device
    {
        /// <summary>
        /// Status of the device on/off
        /// </summary>
        Status status { get; }
        /// <summary>
        /// Volume of the device 0 - 50
        /// </summary>
        int volume { get; }
        /// <summary>
        /// Turns the device on
        /// </summary>
        void on();
        /// <summary>
        /// Turns the device off
        /// </summary>
        void off();
        /// <summary>
        /// Volume up
        /// </summary>
        void volumeUp();
        /// <summary>
        /// Volume down
        /// </summary>
        void volumeDown();
    }
}
