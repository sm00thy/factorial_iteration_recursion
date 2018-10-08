using System;

namespace silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj n: ");
            if(!ulong.TryParse(Console.ReadLine(), out ulong n) || n > 65)
            {
                throw new InvalidOperationException("Bad input or too big number!");
            }

            Console.Write("Silnia rekurencyjnie: ");
            Console.WriteLine(FactorialRecursion.FactorialRecur(n));

            Console.Write("Silnia iteracyjnie: ");
            Console.WriteLine(Factorial.Factor(n));

        }
    }
}
