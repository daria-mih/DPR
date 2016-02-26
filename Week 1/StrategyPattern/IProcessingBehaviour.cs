using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IProcessingBehaviour
    {
        /// <summary>
        /// Interface for implementing different ways of processing numbers(processes)
        /// </summary>
        /// <param name="current"></param>
        /// <param name="pl"></param>
        /// <returns></returns>
        int Run(int current, BindingList<int> pl);
    }
}
