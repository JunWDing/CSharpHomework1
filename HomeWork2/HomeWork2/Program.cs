using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string input = "";
            Console.WriteLine("请输入一个数:");
            input = Console.ReadLine();
            Console.WriteLine("该数的所有素数因子为:");
            try
            {
                num = Int32.Parse(input);
                for(int i=2;i<=num;i++)
                {
                    if(num%i==0)
                    {
                        int flag = 0;
                        for(int j=2;j<i;j++)
                        {
                            if (i % j == 0)
                                flag = 1;
                        }
                        if (flag == 0)
                            Console.WriteLine(i);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("输入错误");
            }
        }
    }
}
