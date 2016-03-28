using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// The prices are standard but the product shipping costs are added
    /// </summary>
    public class OnlinePurchase : IVisitor
    {
        public double visit(Camera camera)
        {
            return camera.price + camera.shippingprice;
        }

        public double visit(Phone phone)
        {
            return phone.price + phone.shippingprice;
        }

        public double visit(Laptop laptop)
        {
            return laptop.price + laptop.shippingprice;
        }
    }
}
