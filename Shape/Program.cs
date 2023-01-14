using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Shape> shapes = new List<Shape>();
            shapes.Add(new Triangle() { A=3, B= 4, C=5});
            shapes.Add(new Rectangle() { A = 2, B = 3});
            shapes.Add(new Circle() { R= 2});

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
