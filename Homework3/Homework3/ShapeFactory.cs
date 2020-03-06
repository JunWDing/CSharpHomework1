using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class ShapeFactory
    {
        public static Shape CreatRandomShape(int type)
        {
            Shape shape = null;
            Random rd = new Random();
            switch(type)
            {
                case 1: 
                    shape = new Rectangle(rd.Next(1, 10), rd.Next(1, 10));
                    while(!shape.IsRight())
                        shape= new Rectangle(rd.Next(1, 10), rd.Next(1, 10));
                    break;

                case 2: shape = new Square(rd.Next(1, 10));
                    while (!shape.IsRight())
                        shape = new Square(rd.Next(1, 10));
                    break;

                case 3: 
                    shape = new Triangle(rd.Next(1, 10), rd.Next(1, 10), rd.Next(1, 10));
                    while(!shape.IsRight())
                        shape=new Triangle(rd.Next(1, 10), rd.Next(1, 10), rd.Next(1, 10));
                    break;
            }
            return shape;
        }

        public static Shape CreatShape(string type)
        {
            Shape shape = null;
            switch(type)
            {
                case "rectangle":
                    double len, wid;
                    Console.WriteLine("请输入长和宽：");
                    len = Double.Parse(Console.ReadLine());
                    wid = Double.Parse(Console.ReadLine());
                    shape = new Rectangle(len, wid);
                    if (!shape.IsRight())
                        Console.WriteLine("该类型不合法");
                    break;
                case "square":
                    double lent;
                    Console.WriteLine("请输入边长：");
                    lent = Double.Parse(Console.ReadLine());
                    shape = new Square(lent);
                    if (!shape.IsRight())
                        Console.WriteLine("该类型不合法");
                    break;
                case "triangle":
                    double e1, e2, e3;
                    Console.WriteLine("请输入三边：");
                    e1 = Double.Parse(Console.ReadLine());
                    e2= Double.Parse(Console.ReadLine());
                    e3= Double.Parse(Console.ReadLine());
                    shape = new Triangle(e1, e2, e3);
                    if (!shape.IsRight())
                        Console.WriteLine("该类型不合法");
                    break;
                default:Console.WriteLine("无此类型");break;
            }
            return shape;
        }
    }
}
