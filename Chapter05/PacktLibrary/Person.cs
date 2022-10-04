using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace Packt.Shared
{
    public partial class Person : Object
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

        public string SayHello()
        {
            return $"{Name}, says hello";
        }

        // Parameter Method(s)
        public string SayHello(string name) // Overload for SayHello() above
        {
            return $"{Name}, says hello to {name}!";
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

        public void PassingParamters(int x, ref int y, out int z)
        {
            // out PARAMETERS cannot have a default
            // must be INITIALISED insdie the method
            z = 99;

            x++; // Will not execute
            y++; // will reference b and increment
            z++; // ignores input and will always put out 100
        }

    }
}