namespace timesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What times table would you like? To quit just hit 'enter'\nEnter a value between 1 and 255:");
            string? user_raw = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(user_raw))
            {
                Console.WriteLine("End of Program");
            }
            else
            {
                try
                {
                    byte user_number = byte.Parse(user_raw);
                    TimesTable(user_number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.GetType()}: Cannot convert input to Byte!");
                }
            }

        }


        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number} times table:");

            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i*number}");
            }
        }

    }
}