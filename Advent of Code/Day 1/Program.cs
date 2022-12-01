using System.ComponentModel.DataAnnotations;

var calories_data = File.ReadAllLines("C:/Users/garet/Documents/AdventOfCode/Day 1 - calorie data.txt");

var data = new List<string>(calories_data);

int elfIndex = 0;
int elfCalorie = 0;
int currentElf = 1;
int currentCalorie = 0;

foreach (var line in data)
    if (line == "")
    {
        if (currentCalorie > elfCalorie)
        {
            elfCalorie = currentCalorie;
            elfIndex = currentElf;
        }

        currentElf++;
        currentCalorie = 0;
    }
    else
    {
        currentCalorie += int.Parse(line);
    }


Console.WriteLine(elfIndex);
Console.WriteLine(currentCalorie);
