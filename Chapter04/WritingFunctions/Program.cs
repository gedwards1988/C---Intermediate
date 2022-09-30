namespace WritingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            TimesTable(6);
            RunCardinalToOrdinal();
            RunFactorial();
            RunFibImperative();
            RunFibFunctional();
        }

        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number} times table");
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Pass a 32-bit integer and it will be converted
        /// to its ordinal equivalent
        /// </summary>
        /// <param name="number"></param>
        /// <returns>
        /// Number as an ordinal value e.g. 1st, 2nd, 3rd and so on
        /// </returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;

                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }


        static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Console.WriteLine($"{CardinalToOrdinal(number)}");
            }
        }


        static int Factorial(int number)
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
                    return number * Factorial(number - 1);
                }
            }
        }


        static void RunFactorial()
        {
            for (int i = 1; i < 15; i++)
            {
                try
                {
                    Console.WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"{i}! is too large for a 32-bit integer.");
                }
            }
        }


        static int FibImperative(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            else if (term == 2)
            {
                return 1;
            }
            else
            {
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }


        static void RunFibImperative()
        {
            for (int j = 1; j <= 30; j++)
            {
                Console.WriteLine("The {0} term of the Fibonacci sequence is {1:N0}",
                    arg0: CardinalToOrdinal(j),
                    arg1: FibImperative(term: j));
            }
        }


        static int FibFunctional(int term) =>
            term switch
            {
                1 => 0,
                2 => 1,
                _ => FibFunctional(term - 1) + FibFunctional(term - 2)
            };


        static void RunFibFunctional()
        {
            for (int j = 1; j <= 30; j++)
            {
                Console.WriteLine("The {0} term of the Fibonacci sequence is {1:N0}",
                    arg0: CardinalToOrdinal(j),
                    arg1: FibFunctional(term: j));
            }
        }


    }
}