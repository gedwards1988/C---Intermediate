namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int population = 66_000_000;
            double weight = 1.88;
            decimal price = 4.99M;
            string fruit = "Apples";
            char letter = 'A';
            bool happy = false;


            string[] names;
            names = new string[4];
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}