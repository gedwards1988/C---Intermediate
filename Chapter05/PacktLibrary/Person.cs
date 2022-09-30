using System;
using System.Collections.Generic;
using System.Text;


namespace Packt.Shared
{
    public class Person : Object
    {
        // Readonly Field(s)
        public readonly string Species = "Homo Sapiens";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantised;

        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;

        // List(s)
        public List<Person> Children = new List<Person>();
       

        // Method(s)
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on {DateOfBirth:dddd}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        // Constructor(s)
        public Person()
        {
            Name = "Unknown";
            Instantised = DateTime.Now;
        }

        public Person(string initialName, String homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantised = DateTime.Now;
        }

        // Deconstructor(s)
        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }

        public void Deconstruct(out string name,
            out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = DateOfBirth;
            fav = FavouriteAncientWonder;
        }

    }
}