using System;
using System.CodeDom;
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

        public string FavouriteIceCream { get; set; }

        private string favouritePrimaryColour;

        // Getter and Setter for private string
        public string FavouritePrimaryColour
        {
            get
            {
                return favouritePrimaryColour;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColour = value;
                        break;
                    default:
                        throw new ArgumentException(
                            $"{value} is not a primary colour. " +
                            "Choose from Red, Green or Blue");
                }
            }
        }





    }
}