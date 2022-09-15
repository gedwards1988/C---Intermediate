using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Methods
{

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var num = int.Parse("ABC");
                Console.WriteLine(num); 
            }
            catch (Exception)
            {

                Console.WriteLine("Conversion is not Valid");
            }


            // var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result == true)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }
            
        }


        static void UseParams()
        {
            var calculator = new calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            // If params keyword is not in method
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }


        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at: ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at: ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}