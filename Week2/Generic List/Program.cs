using System;

namespace Generic_List
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
        private Node<T> _head;
        private Node<T> _tail;
        public GenericList()
        {
            _tail = _head = null;
        }
      
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (_tail == null)
            {
                _head = _tail = n;
            }
            else
            {
                _tail.Next = n;
                _tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> node = this._head;
            while (node != null)
            {
                action(node.Data);
                node = node.Next;
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            Random num = new Random();
            int first = num.Next(0,10);
            int last = num.Next(20, 30);

            for (int x = first; x < last; x++)
            {
                int a = num.Next(0, 100);
                intlist.Add(a);
            }
            int max = int.MinValue;

            intlist.ForEach(m => Console.WriteLine(m));

            intlist.ForEach(m => { if (m > max) max = m; });
            Console.WriteLine("Max：" + max);

            int min = int.MaxValue;
            intlist.ForEach(m => { if (m < min) min = m; });
            Console.WriteLine("Min：" + min);

            int sum = 0;
            intlist.ForEach(m => sum += m);
            Console.WriteLine("Sum：" + sum);
        }
    }
}
