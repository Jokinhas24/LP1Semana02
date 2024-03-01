using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert and height for a Cylinder: ");
            string h = Console.ReadLine();
            float height = float.Parse(h);

            Console.Write("Now Insert a radius for the Base: ");
            string r = Console.ReadLine();
            float radius = float.Parse(r);

            //UI purposes
            Console.WriteLine("");

            //PI R ^2 A
            float V = MathF.PI * MathF.Pow(radius, 2) * height;
            Console.WriteLine($"The Volume of the Cylinder is: {V}");

            //2 PI R

            float Sa = 2 * MathF.PI * radius;
            Console.WriteLine($"And the Area of the Base is: {Sa}");
        }
    }
}
