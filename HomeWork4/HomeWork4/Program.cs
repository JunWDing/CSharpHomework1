using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public static void ForEach(GenericList<T> list,Action<T> action)
        {
            Node<T> pre = list.Head;
            while(pre!=null)
            {
                action(pre.Data);
                pre = pre.Next;
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(0);
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            int max=genericList.Head.Data, min= genericList.Head.Data;
            GenericList<int>.ForEach(genericList, m => Console.WriteLine(m));
            Action<int> action1 = (m) => {
                if (max < m)
                    max = m;
            };
            Action<int> action2 = (m) => {
                if (min > m)
                    min = m;
            };
            GenericList<int>.ForEach(genericList, action1);
            GenericList<int>.ForEach(genericList, action2);
            Console.WriteLine($"最大值值为{max}，最小值为{min}");
        }
    }
}
