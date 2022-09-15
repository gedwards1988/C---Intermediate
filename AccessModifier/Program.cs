namespace AccessModifier
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1988, 03, 16));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}