using System;
namespace silnia
{
    public static class Factorial
    {
        public static ulong Factor(ulong n)
        {
            ulong result = 1;
            Console.Write(result + " * ");

            for (ulong i = 2; i <= n; i++)
            {
                if (i == n)
                {
                    Console.Write(n + " = ");
                }
                else
                {
                    Console.Write(i + " * ");
                }

                result *= i;
            }
            return result;
        }
    }
}
