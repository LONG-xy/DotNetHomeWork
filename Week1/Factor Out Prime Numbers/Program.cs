using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Program.FactorOut(num);
        }
        private static void FactorOut(int num)
        {
            for (int i = 2; i < num; i++)
            {
                    while (num != i)
                    {
                        if (num % i == 0)
                        {
                            Console.Write(i + " ");
                            num /= i;
                        }
                        else break;
                    }
            }
            Console.WriteLine(num);
        }
    }
}
