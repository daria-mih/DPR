using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// The prices are reduced by a discount 
    /// and the shipping costs are then added
    /// </summary>
    public class OnlineSalePurchase : IVisitor
    {
        public double visit(Camera camera)
        {
            return camera.price * 0.94 + camera.shippingprice;
        }

        public double visit(Phone phone)
        {
            return phone.price * 0.90 + phone.shippingprice;
        }

        public double visit(Laptop laptop)
        {
            return laptop.price * 0.83 + laptop.shippingprice;
        }
    }
}
