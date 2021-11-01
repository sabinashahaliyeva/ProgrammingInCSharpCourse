using System;

namespace lesson_3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci sozu daxil edin");

            string name1 = Console.ReadLine();

            Console.WriteLine("ikinci sozu daxil edin");

            string name2 = Console.ReadLine();

            if (name1.Contains(name2))
            {
                Console.WriteLine(" birinci ifade ikinciye daxildir");
            }

            else
            {
                Console.WriteLine("birinci ifade ikinciye daxil deyil");
            }

            Console.ReadLine();
        }

    }
}
