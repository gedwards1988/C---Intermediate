namespace C03_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse("34");
            DateTime birthday = DateTime.Parse("16 March 1988");

            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");


            Console.WriteLine("How many eggs are there?");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse that input.");
            }

            // Create FizzBuzz
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //Division - Error Handling to check valid input
            Console.WriteLine("Enter a whole number between 0 and 255:");
            string? raw_1 = Console.ReadLine();
            Console.WriteLine("Enter another number between 0 and 255:");
            string? raw_2 = Console.ReadLine();

            try
            {
                int num_1 = int.Parse(raw_1);
                int num_2 = int.Parse(raw_2);

                Console.WriteLine($"{num_1} / {num_2} = {num_1/num_2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says: Input String was not in correct format");
            }


            int x = 3;
            int y = 2 + ++x;
            // Output 3 + (x + 1)
            Console.WriteLine(y);

        }
    }
}