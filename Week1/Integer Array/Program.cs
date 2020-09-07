using System;

namespace Integer_Array
{
    class Program
    {
            static void Main(string[] args)
            {
                int[] a = { 13, 4, 25, 8, 33, 6, 53, 8, 19 };
                Max(a);
                Min(a);
                Sum(a);
                Average(a);
                Console.ReadLine();
            }
            private static void Max(int[] a)
            {
                int max = a[0];
                foreach (int x in a)
                {
                    if (x > max)
                    {
                        max = x;
                    }
                }
                Console.WriteLine("MAX" + max);
            }
            private static void Min(int[] a)
            {
                int min = a[0];
                foreach (int x in a)
                {
                    if (x < min)
                    {
                        min = x;
                    }
                }
                Console.WriteLine("MIN" + min);
            }
            private static void Sum(int[] a)
            {
                int sum = 0;
                foreach (int x in a)
                {
                    sum += x;
                }
                Console.WriteLine("SUM" + sum);
            }
            private static void Average(int[] a)
            {
                double sum = 0;
                foreach (int x in a)
                {
                    sum += x;
                }
                double average = sum / a.Length;
                Console.WriteLine("AVG" + average);
            }
        }
    
}
