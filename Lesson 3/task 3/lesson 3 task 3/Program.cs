using System;

namespace lesson_3_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci eded eded daxil edin");

            float eded1 = float.Parse(Console.ReadLine());

            Console.WriteLine("ikinci ededi daxil edin");

            float eded2 = float.Parse(Console.ReadLine());

            Console.WriteLine(eded1 / eded2);

            Console.ReadLine();
        }
    }
}
