using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Practice
    {
        public string Brand;
        public string Type;
        public String Colour;

        public void Action()
        {
            if (Type == "Pen")
            {
                Console.WriteLine("{0}s are for writing", Type);
            }
            else if (Type == "Marker")
            {
                Console.WriteLine("{0}s are for writing on WHiteboards", Type);
            }
        }

        public static Practice Parse(string brand, string type, string colour)
        {
            var practice = new Practice();
            practice.Brand = brand;
            practice.Type = type;
            practice.Colour = colour;

            return practice;
        }
    }
}
