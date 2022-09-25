namespace taxFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var gb = CalculatorTax(10000, "ch");
            Console.WriteLine(gb);

        }


        static decimal CalculatorTax(decimal amount, string twoLetterRegion)
        {
            decimal rate = 0.0M;

            switch(twoLetterRegion.ToLower())
            {
                case "ch":
                    rate = 0.0M;
                    break;
                case "dk":
                case "no":
                    rate = 0.25M;
                    break;
                case "gb":
                case "fr":
                    rate = 0.2M;
                    break;
                case "hu":
                    rate = 0.27M;
                    break;
                default:
                    rate = 0.06M;
                    break;
            }

            return amount * rate;
        }
    }
}