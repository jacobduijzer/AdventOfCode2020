using System.Collections.Generic;
using AdventOfCode.Core.TobogganTrajectory;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode.Tests.TobogganTrajectory
{
    public class TrajectoryCalculatorShould : TestBase
    {
        public TrajectoryCalculatorShould(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        [Theory]
        [InlineData("testinput.txt", 7)]
        [InlineData("fullinput.txt", 274)]
        public void CountTreesOnPath_1(string filename, int expected)
        {
            // ARRANGE
            var sut = new TrajectoryCalculator($"TobogganTrajectory/{filename}");

            // ACT
            var numberOfTrees = sut.TraverseMap(new List<(int verticalStep, int horizontalStep)>{(verticalStep: 1, horizontalStep: 3)}, x => x == '#');

            // ASSERT
            numberOfTrees.Should().Be(expected);
        }

        [Theory]
        [InlineData("testinput.txt", 336)]
        [InlineData("fullinput.txt", 6050183040)]
        public void CountTreesOnPath_2(string filename, long expected)
        {
            // ARRANGE
            var sut = new TrajectoryCalculator($"TobogganTrajectory/{filename}");

            // ACT
            var numberOfTrees = sut.TraverseMap(new List<(int verticalStep, int horizontalStep)>
            {
                (verticalStep: 1, horizontalStep: 1),
                (verticalStep: 1, horizontalStep: 3),
                (verticalStep: 1, horizontalStep: 5),
                (verticalStep: 1, horizontalStep: 7),
                (verticalStep: 2, horizontalStep: 1)
            }, x => x == '#');

            // ASSERT
            numberOfTrees.Should().Be(expected);
        }
    }
}