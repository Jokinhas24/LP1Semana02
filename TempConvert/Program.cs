using System;
using System.Net;
using System.Security.Cryptography;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert a temperature:");
            int t = int.Parse(Console.ReadLine());

            Console.WriteLine("and is it 'C' (for Celsius) or F (for Fahrenheit)");
            string og = Console.ReadLine();
        }
    }
}
