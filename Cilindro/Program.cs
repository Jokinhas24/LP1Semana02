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

            //PI R ^2 A

            Console.WriteLine(MathF.PI * MathF.Low(r, 2) * h);

            //2 PI R
        }
    }
}
