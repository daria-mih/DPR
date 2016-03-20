using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface Command
    {
        /// <summary>
        /// Execute the command
        /// </summary>
        void execute();
        /// <summary>
        /// Do the exact oposite of the command
        /// </summary>
        void undo();
    }
}
