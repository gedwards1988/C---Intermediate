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
    }
}