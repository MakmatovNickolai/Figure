using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Triangle : Figure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public Triangle(int a, int b, int c)
        {
            if (!(a + b > c && a + c > b && b + c > a))
            {
                throw new ArgumentException("No Triangle with given sides");
            }

            int[] sides = new int[3] { a, b, c };
            sides = sides.OrderBy(x=>x).ToArray();
            this.A = sides[0];
            this.B = sides[1];
            this.C = sides[2];	       
        }
        public bool IsRight()
        {
            return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2);
        }
        public override double CalcSquare()
        {
            double S = 0;
            if (IsRight())
            {
                S = A * B / 2;
            }
            else
            {
                int p = (A + B + C) / 2;
                S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            return S;
        }
    }
}
