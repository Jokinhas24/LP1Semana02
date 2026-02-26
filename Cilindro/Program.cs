using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Whats the cylinder Heigh?");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Whats the cylinder radius?");
            double r = double.Parse(Console.ReadLine());

            double v = Math.PI * Math.Pow(r, 2) * a;

            Console.WriteLine("Volume of the cylinder is:", v);

        }
    }
}
