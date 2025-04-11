using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape
{
    class Triangle : IShape
    {
        /// <summary>
        /// Поля
        /// </summary>
        string name;
        double side1;
        double side2;
        double side3;
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Triangle(string name, double side1, double side2, double side3)
        {
            this.Name = name;
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }
        /// <summary>
        /// инкапсуляция
        /// </summary>
        public string Name { get => name; set => name = value; }
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Side3 { get => side3; set => side3 = value; }

        public void Area()
        {
            double pp = (Side1+Side2+Side3)/2;
            Console.WriteLine(Math.Sqrt(pp*(pp-side1)*(pp-side2)*(pp-side3)));
        }
        public void Perimeter()
        {
            Console.WriteLine(Side1+Side2+Side3);
        }
        public override string ToString()
        {
            return $"Фигура:Треугольник\nСторона 1:{Side1} \nСторона 2:{Side2} \nСторона 3:{Side3}";
        }
    }
}
