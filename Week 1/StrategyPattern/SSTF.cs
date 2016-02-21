using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// Shortest seektime first
    /// (smallest difference between adjacent processes)
    /// </summary>
    class SSTF : IProcessingBehaviour
    {
        public int Run(BindingList<int> pl)
        {
            throw new NotImplementedException();
        }
    }
}
