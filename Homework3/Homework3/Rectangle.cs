using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Rectangle: Shape
    {
        private double width;
        private double height;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0 || value == 0)
                    Console.WriteLine("错误");
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0 || value == 0)
                    Console.WriteLine("错误");
                height = value;
            }
        }
        public Rectangle(double len,double heig)
        {
            this.width = len;
            this.height = heig;
        }
        public double GetArea()
        {
            double area = width * height;
            if(IsRight())
                return (width*height);
            return -1;
        }
        public bool IsRight()
        {
            return (width > 0 && height > 0);
        }
    }
}
