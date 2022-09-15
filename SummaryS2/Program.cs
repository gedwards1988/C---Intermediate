namespace SummaryS2
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter your Date of Birth:\n>>");
            string user_dob = Console.ReadLine();
            var dateTime = DateTime.Parse(user_dob);


            Console.WriteLine("How old do you want to be when you die?\n>>");
            var user_deathAge = Convert.ToInt16(Console.ReadLine());

            var person = new Person(dateTime, user_deathAge);
            Console.WriteLine(person.Age());
            Console.WriteLine(person.TilDeath());
        }
    }
}