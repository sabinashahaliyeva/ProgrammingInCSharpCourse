using System;

namespace secondlessontask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the radius ");

            double radius = float.Parse(Console.ReadLine ());

            double perimetr = 2 * Math.PI * radius;
            Console.WriteLine("perimetr = " + perimetr );

            double sahe = 2 * Math.PI * radius * radius;
            Console.WriteLine(" sahe =" +sahe );
        }
    }
}
