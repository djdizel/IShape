using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape
{
    class Rectangle : IShape
    {
        string name;
        double side1;
        double side2;

        public Rectangle(string name, double side1, double side2)
        {
            this.Name = name;
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public string Name { get => name; set => name = value; }
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public void Area()
        {

        }

        public override string ToString() 
        { 
        }
    }
}
