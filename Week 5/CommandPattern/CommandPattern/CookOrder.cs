using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CookOrder : Order
    {
        Cook cook;

        public CookOrder (Cook cook)
        {
            this.cook = cook;
        }

        public void execute()
        {
            cook.cook();
        }
    }
}
