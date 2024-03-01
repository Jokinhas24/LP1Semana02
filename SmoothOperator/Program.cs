using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a positive integer: ");
            string n = Console.ReadLine();
            byte numb = byte.Parse(n);

            Console.WriteLine(--numb);
            Console.WriteLine(++numb);
            Console.WriteLine(numb / 2);
            Console.WriteLine(3 << numb);
            Console.WriteLine(numb ^ 5);
            Console.WriteLine(numb < 10);
        }
    }
}
