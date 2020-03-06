using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Square: Shape
    {
        private double length;
        private double width;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0 || value == 0)
                    Console.WriteLine("错误");
                length = width = value;
            }
        }
        public double Width { get; }
        public Square(double len)
        {
            this.length = len;
            this.width = len;
        }
        public double GetArea()
        {
            if(IsRight())
                return (length * width);
            return -1;
        }
        public bool IsRight()
        {
            return (length > 0);
        }
    }
}
