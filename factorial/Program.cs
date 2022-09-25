using System;
using System.Reflection.Metadata.Ecma335;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 15; i++)
            {
                try
                {
                    Console.WriteLine($"{i}! = {factorial(i):N0}");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"{i}! is too big for a 32-bit integer");
                }
            }

            for(int j = 1; j <= 30; j++)
            {
                Console.WriteLine($"{j} - {FibImperative(j)}");
                Console.WriteLine($"{j} - {FibFunctional(j)}");
            }
        }

        /// <summary>
        /// Pass a 64-bit integer value and it will be converted into
        /// its factorial
        /// </summary>
        /// <param name="number"></param>
        /// <returns>number as a factorial</returns>
        static int factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                checked
                {
                    return number * factorial(number - 1);
                }
            }
        }

        static int FibImperative(int term)
        {
            if(term == 1)
            {
                return 0;
            }
            else if(term == 2)
            {
                return 1;
            }
            else
            {
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }

        static int FibFunctional(int num) =>
            num switch
            {
                1 => 0,
                2 => 1,
                _ => FibFunctional(num - 1) + FibFunctional(num - 2)
            };
        

    }
}