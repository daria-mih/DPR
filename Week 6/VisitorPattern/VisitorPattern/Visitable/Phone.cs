using System;

namespace VisitorPattern
{
    public class Phone : IVisitable
    {
        public double price { get; private set; }
        public double shippingprice { get; private set; }
        public Phone(double itemrprice)
        {
            price = itemrprice;
            shippingprice = 3.51;
        }
        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}