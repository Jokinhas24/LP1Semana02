using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sbyte
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            //byte
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            //double
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            //float
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            //int
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            //uint
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            //long
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            //ulong
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);

            //UI purposes
            Console.WriteLine("");

            //+infinity and -infinity
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity);

            //NaN
            Console.WriteLine(double.NaN);

            //UI purposes + next exercise
            Console.WriteLine("");

            //Overflow
            uint ui = uint.MaxValue
            Console.WriteLine(ui + 1);


        }
    }
}
