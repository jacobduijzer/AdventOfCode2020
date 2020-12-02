using System.Collections.Generic;
using AdventOfCode.Core.PasswordValidation;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.Tests.PasswordValidation
{
    public class PasswordValidatorShould
    {
        [Theory]
        [InlineData("1-2 n: jdfwnn")]
        public void ValidateWithMethod1(string input)
        {
            // ARRANGE & ACT
            var result = PasswordValidator.FirstValidation(input);

            // ASSERT
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("3-4 n: jdfwnn")]
        public void NotValidateWithMethod1(string input)
        {
            // ARRANGE & ACT
            var result = PasswordValidator.FirstValidation(input);

            // ASSERT
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("1-3 a: abcde")]
        public void ValidateWithMethod2(string input)
        {
            // ARRANGE & ACT
            var result = PasswordValidator.SecondValidation(input);

            // ASSERT
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("1-3 b: cdefg")]
        [InlineData("2-9 c: ccccccccc")]
        public void NotValidateWithMethod2(string input)
        {
            // ARRANGE & ACT
            var result = PasswordValidator.SecondValidation(input);

            // ASSERT
            result.Should().BeFalse();
        }
    }
}