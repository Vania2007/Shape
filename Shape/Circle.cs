using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Circle:Shape
    {
        public double R { get; set; }
        public override double GetPerimetr=> 2* Math.PI * R;
        
        public override double GetSquare=> Math.PI * (R*R);
        
    }
}
