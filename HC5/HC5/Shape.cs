using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC5
{
    class Shape
    {
        public string name;
        virtual public double Calculate() { return 1; }
    }
    class Triangle : Shape
    {
        public double a, b, c;
        Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Calculate()
        {
            double d = (a + b + c) / 2;
            return Math.Sqrt(d * (d - a) * (d - b) * (d - c) / 2);
        }
    }
    class Rectangle : Shape
    {
        public double a, b;
        Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Calculate()
        {
            return a * b;
        }
    }
}
