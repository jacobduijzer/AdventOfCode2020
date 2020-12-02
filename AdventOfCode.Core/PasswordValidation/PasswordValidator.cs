using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Core.PasswordValidation
{
    public static class PasswordValidator
    {
        public static bool FirstValidation(string input) =>
            GetPasswordFromString(input)
                .ValidateWithMethod1();

        public static bool SecondValidation(string input) =>
            GetPasswordFromString(input)
                .ValidateWithMethod2();

        private static bool ValidateWithMethod1(this Password password) =>
            password.PasswordString.Count(x => x == password.Character) >= password.FirstNumber &&
            password.PasswordString.Count(x => x == password.Character) <= password.LastNumber;

        private static bool ValidateWithMethod2(this Password password) =>
            password.PasswordString[password.FirstNumber - 1].Equals(password.Character) ^
            password.PasswordString[password.LastNumber - 1].Equals(password.Character);

        private static Password GetPasswordFromString(string input)
        {
            var values = input.Split(':');
            var password = values[1].Trim();

            var occurrences = new Regex("[0-9]+").Matches(values[0]);
            var passwordCharacter = char.Parse(new Regex("[a-zA-Z]").Match(values[0]).Value);

            return new Password(
                password,
                passwordCharacter,
                int.Parse(occurrences[0].Value),
                int.Parse(occurrences[1].Value));
        }
    }
}