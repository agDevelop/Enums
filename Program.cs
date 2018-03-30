using System;

namespace Enums
{
    enum Number
    {
        Zero,
        One,
        Two,
        Three
    }

    class Program
    {
        private static Number myDigit = Number.One;

        static void Main(string[] args)
        {
            Number digit = Number.Two;

            Console.WriteLine(digit);

            Console.WriteLine((int)digit);

            Console.WriteLine(new string('-', 10));

            Console.WriteLine(Number.Three);

            Console.WriteLine((int)Number.Three);

            Console.WriteLine((int)myDigit);

            Console.ReadKey();
        }
    }
}
