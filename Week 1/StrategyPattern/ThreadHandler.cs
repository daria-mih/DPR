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

        public Random rnd = new Random();
        int myNumber = 0;
        public List<int> randomList = new List<int>();


        public void GenerateNewNumber()
        {
            myNumber = rnd.Next(1, 100);
            if (!randomList.Contains(myNumber))
            {
                randomList.Add(myNumber);

            }

        }

        public void FilltheList()
        {
            for (int i = 0; i < 101; i++)
            {
                GenerateNewNumber();
            }
        }


     
    }
}
