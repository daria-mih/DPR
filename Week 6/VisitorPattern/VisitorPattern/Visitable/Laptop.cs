using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// Just a laptop object with price & shippingprice
    /// accept 
    /// </summary>
    public class Laptop : IVisitable
    {
        public double price { get; private set; }
        public double shippingprice { get; private set; }
        public Laptop(double itemprice)
        {
            price = itemprice;
            shippingprice = 11.26;
        }
        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
