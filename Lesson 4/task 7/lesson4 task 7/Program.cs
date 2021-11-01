using System;

namespace lesson4_task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci ededi daxil edin");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ikinci ededi daxil edin");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ucuncu ededi daxil edin");
            int number3 = int.Parse(Console.ReadLine());

            if ((number1 > number2) && (number1 > number3)) 
            {
                Console.WriteLine("birinci eded ededlerin arasinda en boyukdur");
            }

            else if ((number2 > number1) && (number2 > number3))
            {
                Console.WriteLine("ikinci eded ededlerin arasinda en boyukdur");
            }

            else if ((number3 > number1) && (number3 > number2))
            {
                Console.WriteLine("ucuncu eded ededlerin arasinda en boyukdur");
            }

            Console.ReadLine();
        }
    }
}
