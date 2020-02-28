using System;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[99];
            for (int i = 2; i <= 100; i++)
                arr[i - 2] = i;
            for (int j = 0; j<10; j++)
            {
                if (arr[j] == 0)
                    continue;
                for (int k = j + 1; k < 99; k++)
                    if (arr[k] % arr[j] == 0)
                         arr[k] = 0;
            }
            for(int counter=0;counter<99;counter++)
                if(arr[counter]!=0)
                    Console.WriteLine(arr[counter]);
        }
    }
}
