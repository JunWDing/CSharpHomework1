using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int a = 0;
            int b = 0;
            int result = 0;
            Console.WriteLine("请输入第一个数字：");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.WriteLine("请输入第二个数字：");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            Console.WriteLine("请输入运算符号：");
            s = Console.ReadLine();
            switch (s)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/": result = a / b; break;
                default: Console.WriteLine("错误"); break;
            }
            Console.WriteLine($"{a}{s}{b}的运算结果为：{result}");
        }
    }
}
