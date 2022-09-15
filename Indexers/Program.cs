namespace Indexers
{

    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Gareth";
            Console.WriteLine(cookie["name"]);
        }
    }
}