using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hetenin hansi gununun oldugunu bilmek ucun gun nomresini daxil edin");
            int day = int.Parse(Console.ReadLine());

            switch (day) 
            { 
              case 1:
            Console.WriteLine("bazar ertesi");
                    break;

                case 2:
                    Console.WriteLine("cersenbe axsami");
                    break;

                case 3:
                    Console.WriteLine("cersenbe");
                    break;

                case 4:
                    Console.WriteLine("cume axsami");
                    break;

                case 5:
                    Console.WriteLine("cume");
                    break;

                case 6:
                    Console.WriteLine("senbe");
                    break;

                case 7:
                    Console.WriteLine("bazar");
                    break;

                default:
                    Console.WriteLine("etibarsiz nomre");
                    break;
            }

            Console.ReadLine();

        }
    }
}
