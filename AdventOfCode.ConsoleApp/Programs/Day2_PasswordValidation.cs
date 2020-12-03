using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode.Core;
using AdventOfCode.Core.PasswordValidation;

namespace AdventOfCode.ConsoleApp.Programs
{
    public class Day2_PasswordValidation : ProgramBase
    {
        private readonly List<string> _input;

        public Day2_PasswordValidation() => _input = File.ReadAllLines("Input/day2.txt").ToList();

        public override void RunExercise1()
        {
            var validPasswords = 0;
            foreach(var line in _input)
                if (PasswordValidator.FirstValidation(line))
                    validPasswords++;

            LogMessage($"valid passwords: {validPasswords}");
        }

        public override void RunExercise2()
        {
            var validPasswords = 0;
            foreach(var line in _input)
                if (PasswordValidator.SecondValidation(line))
                    validPasswords++;

            LogMessage($"valid passwords: {validPasswords}");
        }
    }
}