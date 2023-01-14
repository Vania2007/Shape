using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Triangle:Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public override double GetPerimetr => A + B + C;
        public override double GetSquare
        {
            get
            {
                int p = (A + B + C) / 2;
                double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                return S;
            }
        }
    }
}
