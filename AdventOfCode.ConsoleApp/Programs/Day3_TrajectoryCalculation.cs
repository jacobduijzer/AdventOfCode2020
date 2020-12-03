using System.Collections.Generic;
using AdventOfCode.Core;
using AdventOfCode.Core.TobogganTrajectory;

namespace AdventOfCode.ConsoleApp.Programs
{
    public class Day3_TrajectoryCalculation : ProgramBase
    {
        private readonly TrajectoryCalculator _trajectoryCalculator;

        public Day3_TrajectoryCalculation() : base() =>
            _trajectoryCalculator = new TrajectoryCalculator("Input/day3.txt");

        public override void RunExercise1()
        {
            var numberOfTrees = _trajectoryCalculator
                .TraverseMap(
                    new List<(int verticalStep, int horizontalStep)> {( verticalStep: 1, horizontalStep: 3 )},
                    x => x == '#');

            LogMessage($"number of trees: Valid amount: {numberOfTrees}");
        }

        public override void RunExercise2()
        {
            var numberOfTrees = new TrajectoryCalculator("Input/day3.txt")
                .TraverseMap(new List<(int verticalStep, int horizontalStep)>
                {
                    ( verticalStep: 1, horizontalStep: 1 ),
                    ( verticalStep: 1, horizontalStep: 3 ),
                    ( verticalStep: 1, horizontalStep: 5 ),
                    ( verticalStep: 1, horizontalStep: 7 ),
                    ( verticalStep: 2, horizontalStep: 1 )
                }, x => x == '#');

            LogMessage($"number of trees: Valid amount: {numberOfTrees}");
        }
    }
}