using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DeclineOrder : Order
    {
        Cook cook;
        public DeclineOrder(Cook cook)
        {
            this.cook = cook;
        }
        public void execute()
        {
           cook.decline();
        }
    }
}
