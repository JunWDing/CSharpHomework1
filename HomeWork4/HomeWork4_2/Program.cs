using System;

namespace HomeWork4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Clock clock = new Clock(10, 18, 30);
            clock.StartTiming(10, 19, 0);
        }
    }
}
