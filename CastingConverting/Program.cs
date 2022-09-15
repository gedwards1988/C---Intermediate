using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            Console.WriteLine(b);

            double c = 9.8;
            // Cannot convert double to int, unless EXPLICIT CAST loses the decimal part
            int d = (int)c;
            Console.WriteLine(d);

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            e = long.MaxValue;
            f = (int)e;
            // f = -1 as max value exceeded for int type
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");


            double g = 9.8;
            int h = ToInt32(g);
            // h = 10 as it rounds to nearest integer value
            Console.WriteLine($"g is {g} and h is {h}");

            // round up - decimal part .5 and non-decimal part is odd
            // round down - decimal part .5 and non-decimal part is even
            double[] doubles = new[] {9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

            foreach(double n in doubles)
            {
                Console.WriteLine($"ToInt32 ({n}) is {ToInt32(n)}");
                Console.WriteLine(format:
                                    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                                    arg0: n,
                                    arg1: Math.Round(value: n, digits: 0,
                                    mode: MidpointRounding.AwayFromZero));
 
            }
            Console.WriteLine();

            int number = 12;
            Console.WriteLine(number.ToString());

            bool boolean = true;
            Console.WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            object me = new();
            Console.WriteLine(me.ToString());

        }

    }
}