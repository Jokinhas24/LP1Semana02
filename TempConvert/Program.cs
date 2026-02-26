using System;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert a temperature:");
            float t = float.Parse(Console.ReadLine());

            Console.WriteLine("and is it 'C' (for Celsius) or F (for Fahrenheit)");
            string og = Console.ReadLine();

            switch (og)
            {
                case "F":
                double tf = t * 1.8 + 32;
                Console.WriteLine("You temperature in the other origin is: " + tf.ToString("F3"));
                    break;
                case "C":
                double tc = (t - 32)/1.8;
                Console.WriteLine("You temperature in the other origin is: " + tc.ToString("F3"));
                    break;
            }
        }
    }
}
