using System;

namespace Chapter3switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(1, 7);
            Console.WriteLine($"My random number is {number}");

            switch(number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    Console.WriteLine("Three or Four");
                    goto case 1;
                case 5:
                    goto A_label;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            Console.WriteLine("After end of each switch!");
        A_label:
            Console.WriteLine($"After A_label");





            string path = @"C:\Users\garet\Documents\C# - Intermediate\Chapter3switch";
            Console.WriteLine("Press R for read-only or W for writeable");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            Stream? s;

            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Read);
            }
            else
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Write);
            }

            string message;

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address";
                    break;
                default:
                    message = "The stream is some other type";
                        break;
                case null:
                    message = "The stream is null";
                    break;
            }

            Console.WriteLine(message);

        }
    }
}