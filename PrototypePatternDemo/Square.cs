using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    public class Square : Shape
    {
        public int side;
        public Square()
        {
            type = "Square";
        }

        public override double GetArea()
        {
            area = side * side;
            return area; 
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Shape))
                return false;
            Square shape = (Square) obj;
            return shape.side == side;
        }
    }
}
