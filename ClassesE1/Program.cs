namespace ClassesE1
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Start / Stop / Exit: \n");
                var userInput = Console.ReadLine().ToLower();

                if(userInput == "exit")
                {
                    break;
                }
                else if(userInput == "start")
                {
                    Console.Clear();
                    Stopwatch.Start();
                    Console.WriteLine("Stopwatch has started ......");
                }
                else if(userInput == "stop")
                {
                    Console.Clear();
                    var duration = Stopwatch.Stop();
                    Console.WriteLine(String.Format("Duration: {0}", duration));
                }
                else
                {
                    Console.WriteLine("Did not understand your input\n>>Please try again");
                }
            }
        }
    }
}