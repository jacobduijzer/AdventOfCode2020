namespace AdventOfCode.Core.PasswordValidation
{
    public sealed record Password(string PasswordString, char Character, int FirstNumber, int LastNumber);
}