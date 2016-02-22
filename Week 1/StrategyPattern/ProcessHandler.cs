using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ProcessHandler
    {
        public IProcessingBehaviour pb;

        public ProcessHandler(IProcessingBehaviour pb)
        {
            this.pb = pb;
        }

        public int PerformRun(int current, BindingList<int> pl)
        {
            return pb.Run(current, pl);
        }
    }
}
