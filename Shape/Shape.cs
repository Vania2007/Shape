using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public abstract class Shape
    {
        public abstract double GetPerimetr { get; }
        public abstract double GetSquare { get; }
        

        public override string ToString()
        {
            return $"Perimetr = {GetPerimetr}; Square = {GetSquare}";
        }
    }

}
