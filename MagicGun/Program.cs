﻿using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of shots: ");
            string numb = Console.ReadLine();

            int n = int.Parse(numb);

            for(int s = 1; s <= n; s++)
            {
                if (s % 3 == 0 && s % 5 == 0)
                {
                    Console.WriteLine($"{s}: Magic Fire! Electric Fire!");
                    continue;
                }
                else if (s % 3 == 0)
                {
                     Console.WriteLine($"{s}: Magic Fire!");
                }
                else if (s % 5 == 0)
                {
                     Console.WriteLine($"{s}: Electric Fire!");
                }
                else
                {
                    Console.WriteLine($"{s}: Normal Fire :/");
                }

            }

        }
    }
}
