namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Console.WriteLine("\n");
            Part2();
        }


        static void Part1()
        {

            var raw_data = File.ReadAllLines("C:/Users/garet/Documents/AdventOfCode/Day 1 - calorie data.txt");
            var data = new List<string>(raw_data);

            int elfId = 0;
            int elfCalorie = 0;

            int currentElf = 1;
            int currentCalorie = 0;

            foreach (var line in data)
            {
                if (line == "")
                {
                    if (currentCalorie > elfCalorie)
                    {
                        elfCalorie = currentCalorie;
                        elfId = currentElf;
                    }

                    currentElf++;
                    currentCalorie = 0;
                }
                else
                {
                    currentCalorie += int.Parse(line);
                }
            }

            Console.WriteLine("Part 1");
            Console.WriteLine("------");
            Console.WriteLine($"Elf carrying the most calories is Elf {elfId} with:");
            Console.WriteLine($"{elfCalorie} calories");

        }

        static void Part2()
        {

            var raw_data = File.ReadAllLines("C:/Users/garet/Documents/AdventOfCode/Day 1 - calorie data.txt");
            var data = new List<string>(raw_data);

            int[] elfCalorie = new int[3];

            int currentCalorie = 0;

            foreach (var line in data)
            {
                if (line == "")
                {
                    for (int i = 2; i >=0; i--)
                    {
                        if (currentCalorie > elfCalorie[i])
                        {
                            if (i != 2)
                            {
                                elfCalorie[i + 1] = elfCalorie[i];
                            }
                            elfCalorie[i] = currentCalorie;
                        }
                    }
                    currentCalorie = 0;
                }
                else
                {
                    currentCalorie += int.Parse(line);
                }
            }

            int overallCalories = 0;

            foreach (int cals in elfCalorie)
            {
                overallCalories += cals;
            }

            Console.WriteLine("Part 2");
            Console.WriteLine("------");
            Console.WriteLine($"The top 3 elves are carrying a total of:");
            Console.WriteLine($"{overallCalories.ToString()} calories");
            Console.WriteLine($"\t{elfCalorie[0]} - 1st");
            Console.WriteLine($"\t{elfCalorie[1]} - 2nd");
            Console.WriteLine($"\t{elfCalorie[2]} - 3rd");
        }


    }
}