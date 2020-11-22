using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    public abstract class Shape
    {
        private string id;
        public string type;
        public double area;
        public Shape()
        {
        }
        public Shape (Shape target)
        {
            if(target != null)
            {
                this.id = target.id;
                this.type = target.type;
            }
        }
        public abstract double GetArea();
        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Shape))
                return false;
            Shape shape = (Shape)obj;
            return shape.area == area && String.Equals(shape.id, id) && String.Equals(shape.type, type);
        }
    }
}
