using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// The prices are reduced by a certain discount.
    /// </summary>
    class LocalSalePurchase : IVisitor
    {
        public double visit(Camera camera)
        {
            return camera.price * 0.94;
        }

        public double visit(Phone phone)
        {
            return phone.price * 0.90;
        }

        public double visit(Laptop laptop)
        {
            return laptop.price * 0.83;
        }
    }
}
