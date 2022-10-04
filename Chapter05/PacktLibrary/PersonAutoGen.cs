using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public partial class Person
    {

        public string Origin
        {
            get 
            {
                return $"{Name} was born on {HomePlanet}";
            }

        }

        public string Greeting => $"{Name} says hello!";

        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

    }
}
