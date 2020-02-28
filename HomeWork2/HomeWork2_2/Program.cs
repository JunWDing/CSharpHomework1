using System;
using System.Collections.Generic;

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            string s = "";
            List<int> arr = new List<int>();
            while (true)
            {
                Console.WriteLine("输入一个数或输入n结束:");
                s = Console.ReadLine();
                if (s == "n")
                    break;
                try
                {
                    int num = Int32.Parse(s);
                    arr.Add(num);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("输入错误");
                }
            }
            a = arr.ToArray();
            cal(a, out int maxnum, out int minnum, out int avenum, out int count);
            Console.WriteLine($"数组的最大值为：{maxnum},最小值为：{minnum},和为:{count},平均数为:{avenum}");
        }

        static void cal(int[] a,out int maxnum,out int minnum,out int avenum,out int count)
        {
            Array.Sort(a);
            maxnum = a[a.Length - 1];
            minnum = a[0];
            count = 0;
            foreach (int arr in a)
                count += arr;
            avenum = count / a.Length;
        }
    }
}
