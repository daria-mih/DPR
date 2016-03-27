using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Laptops : IVisitable
    {
        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
