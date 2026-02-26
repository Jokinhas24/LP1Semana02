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
            double s = 2 * Math.PI * r * (r + a);

            Console.WriteLine("Volume of the cylinder is: " + v.ToString("F3"));
            Console.WriteLine("Area of the cylinder is: " + s.ToString("F3"));
        }
    }
}
