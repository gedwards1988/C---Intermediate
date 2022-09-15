namespace Properties
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1988, 03, 16));
            Console.WriteLine(person.Age);
        }
    }
}