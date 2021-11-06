using System;

namespace task_4
{
    class Program
    {

        static void Main(string[] args)
        {
            ChangePlaceOfNumber(5,11);
        }

        static void ChangePlaceOfNumber(int a, int b)
        {
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($"{a},{b} ");
        }
    }
}
