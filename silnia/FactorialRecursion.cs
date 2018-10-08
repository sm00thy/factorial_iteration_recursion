using System;
namespace silnia
{
    public static class FactorialRecursion
    {
        public static ulong FactorialRecur(ulong n)
        {
            if (n == 1)
            {
                Console.Write(n + " = ");
            }
            else
            {
                Console.Write(n + " * ");
            }

            return (n > 1) ? n * FactorialRecur(n - 1) : 1;
        }
    }
}
