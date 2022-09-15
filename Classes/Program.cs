namespace Classes
{
    public class Person
    {
        public string Name;
        public int Age;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1} and I am {2} years old", to, Name, Age);
        }

        public void Talent(string activity)
        {
            Console.WriteLine("I am {0} and my talent is {1}", Name, activity);
        }

        public static Person Parse(string str, int age)
        {
            var person = new Person();
            person.Name = str;
            person.Age = age;

            return person;
        }
    }

    public class House
    {
        public int Width;
        public int Height;

        public void houseSize()
        {
            var total_size = Height * Width;
            var status = "Normal";
            if (total_size > 100)
            {
                status = "Large House";
            }
            else
            {
                status = "Normal House";
            }
            Console.WriteLine("Total House Size is : {0} which is {1}", total_size, status);
        }

        // Allows us to parse values into attributes directly
        public static House Parse(int Width, int Height)
        {
            var house = new House();
            house.Width = Width;
            house.Height = Height;

            return house;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var p1 = Person.Parse("Person 1", 34);
            p1.Introduce("Person 0");
            p1.Talent("Golf");

            var p2 = Person.Parse("Person 2", 40);
            p2.Introduce(p1.Name);


            var h1 = House.Parse(10, 11);
            h1.houseSize();

            var prac1 = Practice.Parse("Tesco", "Pen", "Blue");
            prac1.Action();

        }
    }
}