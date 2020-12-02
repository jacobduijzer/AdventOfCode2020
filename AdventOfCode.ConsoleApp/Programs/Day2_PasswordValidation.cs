using System;
using System.IO;
using System.Linq;
using AdventOfCode.Core.PasswordValidation;

namespace AdventOfCode.ConsoleApp.Programs
{
    public static class Day2_PasswordValidation
    {
        public static void Run()
        {
            int valid = 0;
            var input = File.ReadAllLines("Input/day2.txt").ToList();
            foreach(var line in input)
                if (PasswordValidator.FirstValidation(line))
                    valid++;

            Console.WriteLine($"Validation method 1: Valid amount: {valid}");

            valid = 0;
            foreach (var line in input)
                if (PasswordValidator.SecondValidation(line))
                    valid++;

            Console.WriteLine($"Validation method 2: Valid amount: {valid}");
        }
    }
}