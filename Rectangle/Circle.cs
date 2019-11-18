using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Circle : Figure
    {
        public int Radius { get; set; }
        public Circle(int Radius)
        {
            this.Radius = Radius;
        }
        public override double CalcSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
