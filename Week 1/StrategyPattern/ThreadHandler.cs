using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class ThreadHandler
    {
        IProcessingBehaviour pb;
        Random rnd = new Random();
        public int myNumber;
        public List<int> randomList = new List<int>();

        public ThreadHandler()
        {

        }

        public void PerformRun()
        {
            pb.Run();
        }
        
     
    }
}
