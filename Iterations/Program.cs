namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }


            // Ask for password
            string? password;
            int attempts = 0;

            do
            {
                Console.WriteLine("Enter your password:\n>>");
                password = Console.ReadLine();
                attempts++;
            }
            while (password != "Pa$$w0rd" && attempts < 9);

            if(attempts == 9)
            {
                Console.WriteLine("Incorrect the password was 'Pa$$w0rd'");
            }
            else
            {
                Console.WriteLine("Correct");
            }
                

            // For loop counter
            for(int j=1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }


            // Foreach loop

            string[] names = { "Gareth", "Sarah", "Faye", "Eve" };

            foreach(string name in names)
            {
                Console.WriteLine(name);
                Console.WriteLine("{0} has {1} characters",
                    name, name.Length);
            }



        }
    }
}