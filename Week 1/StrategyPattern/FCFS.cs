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
    public class FCFS: IProcessingBehaviour
    {
        public int Run(int current, BindingList<int> pl)
        {
            return pl[0];
        }
        
    }
}
