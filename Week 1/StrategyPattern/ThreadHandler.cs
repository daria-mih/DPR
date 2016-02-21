using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class ThreadHandler
    {
        ProcessingBehaviour pb;
        public void PerformRun()
        {
            pb.Run();
        }

        Random rnd = new Random();
        public int myNumber;
        myNumber = rnd.Next(1, 100);
        public List<int> randomList = new List<int>();
        
     
    }
}
