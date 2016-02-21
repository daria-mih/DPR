using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// First Come First Serve
    /// </summary>
    class FCFS: IProcessingBehaviour
    {
        public int Run(BindingList<int> pl)
        {
            return pl[0];
        }
        
    }
}
