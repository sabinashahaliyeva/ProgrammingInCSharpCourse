using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, var1, sum = 0;

            Console.WriteLine("hansisa bir ededi daxil edin");
            int eded = int.Parse(Console.ReadLine());

            for (i = eded ; eded != 0; eded /= 10 )
            {
                var1 = eded % 10;
                sum = sum * 10 + var1;
            }

            if (i == sum)
            {
                Console.WriteLine( " {0} polindrom ededdir", i);
            }

            else
            {
                Console.WriteLine(" {0} polindrom eded deyil", i);
            }

            Console.ReadLine();
        }
    }
}
