using System;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Temperature: ");
            float t = float.Parse(Console.ReadLine());

            Console.Write("Unit (C/F): ");
            string og = Console.ReadLine();

            switch (og)
            {
                case "C":
                    double tc = (t * 1.8) + 32;
                    Console.WriteLine(t.ToString("F2") + " C = " + tc.ToString("F2") + " F");
                    Console.WriteLine("Absolute value: " + Math.Abs(tc).ToString("F2"));
                    break;

                case "F":
                    double tf = (t - 32)/1.8;
                    Console.WriteLine(t.ToString("F2") + " F = " + tf.ToString("F2") + " C");
                    Console.WriteLine("Absolute value: " + Math.Abs(tf).ToString("F2"));
                    break;

                default:
                    Console.WriteLine("Invalid unit.");
                    break;
            }
        }
    }
}
