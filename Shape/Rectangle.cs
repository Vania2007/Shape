using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    internal class Rectangle: Shape
    {
        public int A { get; set; }
        public int B { get; set; }
       
        public override double GetPerimetr => A + B;
        public override double GetSquare => A * B;
        
    }
}
