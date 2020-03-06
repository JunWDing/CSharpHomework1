using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Shape[] shapes = new Shape[10];
            double totalArea = 0;

            for (int i = 0; i < 10; i++)
                shapes[i] = ShapeFactory.CreatRandomShape(rd.Next(1, 3));

            foreach (Shape shape in shapes)
                totalArea += shape.GetArea();

            Console.WriteLine(totalArea);
        }
    }
}
