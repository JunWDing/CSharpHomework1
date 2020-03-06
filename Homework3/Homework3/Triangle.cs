using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Triangle: Shape
    {
        private double edge1;
        private double edge2;
        private double edge3;
        public double Edge1
        {
            get
            {
                return edge1;
            }
            set
            {
                if (value < 0 || value == 0)
                    Console.WriteLine("错误");
                edge1 = value;
            }
        }
        public double Edge2
        {
            get
            {
                return edge2;
            }
            set
            {
                if (value < 0 || value == 0)
                    Console.WriteLine("错误");
                edge2 = value;
            }
        }
        public double Edge3
        {
            get
            {
                return edge3;
            }
            set
            {
                if (value < 0 || value == 0)
                    Console.WriteLine("错误");
                edge3 = value;
            }
        }
        public Triangle(double e1,double e2,double e3)
        {
            edge1 = e1;
            edge2 = e2;
            edge3 = e3;
        }
        public double GetArea()
        {
            double s = 0;
            if (IsRight())
            {
                double p = (edge1 + edge2 + edge3) / 2;
                s = Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
            }
            else
                s= -1;
            return s;
        }
        public bool IsRight()
        {
            if (edge1 > 0 && edge2 > 0 && edge3 > 0)
                if (edge1 + edge2 > edge3 && edge1 + edge3 > edge2 && edge2 + edge3 > edge1)
                    return true;
            return false;
        }
    }
}
