using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// A local purchase costs the standard price. 
    /// No price adjustments are required.
    /// </summary>
    public class LocalPurchase : IVisitor
    {
        public double visit(Camera camera)
        {
            return camera.price;
        }

        public double visit(Phone phone)
        {
            return phone.price;
        }

        public double visit(Laptop laptop)
        {
            return laptop.price;
        }
    }
}
