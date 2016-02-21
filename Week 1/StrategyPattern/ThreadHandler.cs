using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ThreadHandler
    {
        public IProcessingBehaviour pb;

        public ThreadHandler(IProcessingBehaviour pb)
        {
            this.pb = pb;
        }

        public int PerformRun(BindingList<int> pl)
        {
            return pb.Run(pl);
        }
    }
}
