using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Waiter
    {
        List<Order> queue; 

        public Waiter()
        {
           queue  = new List<Order>();
        }

        public void PlaceOrder (Order order)
        {
            queue.Add(order);
            order.execute();
        }
    }
}
