using Packt.Shared;
using PacktLibrary;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Instance of Person Class
            Person bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

            Console.WriteLine(format: "{0} loves the {1}.{2}",
                arg0: bob.Name,
                arg1: (int)bob.FavouriteAncientWonder,
                arg2: bob.FavouriteAncientWonder);

            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

            // Another Instance of Person Class
            Person alice = new()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1988, 3, 7),
                FavouriteAncientWonder = WondersOfTheAncientWorld.TempleOfArtemisAtEphesus
            };

            Console.WriteLine(format: "{0} was born on {1: dd MM yyyy} and loves the {2}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth,
                arg2: alice.FavouriteAncientWonder);

            // Adding a list to Instance of Bob
            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });

            Console.WriteLine($"{bob.Name} is of the Species {bob.Species}");
            Console.WriteLine($"{bob.Name} was born on the planet {bob.HomePlanet}");

            Console.WriteLine(
                $"{bob.Name} has {bob.Children.Count} children");

            // For loop to access list in Bob
            for(int i = 0; i < bob.Children.Count; i++)
            {
                Console.WriteLine($"{bob.Children[i].Name}");
            }

            foreach(var child in bob.Children)
            {
                Console.WriteLine(child.Name);
            }


            Person blankPerson = new();

            Console.WriteLine(format:
                "{0} of {1} was created at {2}",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantised);

            Person gareth = new("Gareth", "Earth");
            Console.WriteLine(format:
                "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
                arg0: gareth.Name,
                arg1: gareth.HomePlanet,
                arg2: gareth.Instantised);

            bob.WriteToConsole();
            Console.WriteLine(bob.GetOrigin());


            //----------------------------------------------------------------------//
            //-------------- BANK ACCOUNT --------------------------------------------
            //----------------------------------------------------------------------//

            BankAccount.InterestRate = 0.012M;

            BankAccount jonesAccount = new();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            Console.WriteLine(format: "{0} earned {1:C} interest",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate);



            BankAccount gerrierAccount = new();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;

            Console.WriteLine(format: "{0} earned {1:C} interest",
                arg0: gerrierAccount.AccountName,
                arg1: gerrierAccount.Balance * BankAccount.InterestRate);

        }
    }
}