using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci ededi daxil edin :");
            float eded1 = float.Parse(Console.ReadLine());

            Console.WriteLine("2ci ededi daxil edin :");
            float eded2 = float.Parse(Console.ReadLine());

            Console.WriteLine("3cu ededi daxil edin :");
            float eded3 = float.Parse(Console.ReadLine());

            Console.WriteLine("4cu ededi daxil edin :");
            float eded4 = float.Parse(Console.ReadLine());

            Console.WriteLine("5ci ededi daxil edin :");
            float eded5 = float.Parse(Console.ReadLine());

            float sum = eded1 + eded2 + eded3 + eded4 + eded5;
            Console.WriteLine(sum);

            float var1 = sum / 2;
            Console.WriteLine(var1);

            Console.ReadLine();
           
        }
    }
}
