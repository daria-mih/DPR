using System;

namespace VisitorPattern
{
    public class Camera : IVisitable
    {
        public double price { get; private set; }
        public double shippingprice { get; private set; }
        public Camera(double itemprice)
        {
            price = itemprice;
            shippingprice = 6.78;
        }
        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}