using System;
using AdventOfCode.Core.ExpenseReport;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.Tests.ExpenseReport
{
    public class ReportCalculatorShould
    {
        private readonly int[] _noResultSampleData = new[] {1, 2, 3, 4, 5, 6, 7};
        private readonly int[] _twoNumberResultSampleData = new[] {1, 2, 3, 4, 1010, 1010, 8, 9, 10};
        private readonly int[] _threeNumberResultSampleData = new[] {1, 2, 3, 4, 5, 6, 1010, 505, 505, 7, 8, 9, 10};

        [Fact]
        public void ReturnTwoNumbersResult()
        {
            // ARRANGE
            var sut = new ReportCalculator(_twoNumberResultSampleData);

            // ACT
            var result = sut.FindTwoNumberResult();

            // ASSERT
            result.Should().BeOfType<TwoNumberResult>();
        }

        [Fact]
        public void ThrowWhenNoTwoNumbersFound()
        {
            new Action(() => new ReportCalculator(_noResultSampleData).FindTwoNumberResult())
                .Should().Throw<Exception>().WithMessage("No numbers found");
        }

        [Fact]
        public void ThrowWhenNoThreeNumbersFound()
        {
            new Action(() => new ReportCalculator(_noResultSampleData).FindThreeNumberResult())
                .Should().Throw<Exception>().WithMessage("No numbers found");
        }

        [Fact]
        public void ReturnTwoNumbersWithTotalOf2020()
        {
            // ARRANGE
            var sut = new ReportCalculator(_twoNumberResultSampleData);

            // ACT
            var result = sut.FindTwoNumberResult();

            // ASSERT
            (result.Number1+result.Number2).Should().Be(ReportCalculator.Total);
        }

        [Fact]
        public void ReturnThreeNumbersResult()
        {
            // ARRANGE
            var sut = new ReportCalculator(_threeNumberResultSampleData);

            // ACT
            var result = sut.FindThreeNumberResult();

            // ASSERT
            result.Should().BeOfType<ThreeNumberResult>();
        }

        [Fact]
        public void ReturnThreeNumbersWithTotalOf2020()
        {
            // ARRANGE
            var sut = new ReportCalculator(_threeNumberResultSampleData);

            // ACT
            var result = sut.FindThreeNumberResult();

            // ASSERT
            (result.Number1 + result.Number2 + result.Number3).Should().Be(ReportCalculator.Total);
        }

        [Fact]
        public void CalculateTotalOfTwo()
        {
            // ARRANGE
            var sut = new ReportCalculator(_twoNumberResultSampleData);

            // ACT
            var numbers = sut.FindTwoNumberResult();

            // ASSERT
            numbers.TotalExpenses.Should().Be(1020100);
        }

        [Fact]
        public void CalculateTotalOfThree()
        {
            // ARRANGE
            var sut = new ReportCalculator(_threeNumberResultSampleData);

            // ACT
            var numbers = sut.FindThreeNumberResult();

            // ASSERT
            numbers.TotalExpense.Should().Be(257575250);
        }
    }
}