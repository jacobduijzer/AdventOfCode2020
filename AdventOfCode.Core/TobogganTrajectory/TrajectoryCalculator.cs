using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Core.TobogganTrajectory
{
    public class TrajectoryCalculator
    {
        private readonly string[] _map;

        public TrajectoryCalculator(string fileName) =>
            _map = File.ReadAllLines(fileName).ToArray();

        public long TraverseMap(List<(int verticalStep, int horizontalStep)> slopes, Func<char, bool> predicate)
        {
            long multiplier = 1;
            var rowLength = _map[0].Length;
            foreach (var (verticalStep, horizontalStep) in slopes)
            {
                var (vertical, horizontal) = ( verticalStep, horizontalStep );
                var numberOfTrees = 0;
                while (vertical < _map.Length)
                {
                    if (predicate(_map[vertical][horizontal % rowLength]))
                        numberOfTrees++;

                    (vertical, horizontal) = (vertical + verticalStep, horizontal + horizontalStep);
                }

                multiplier *= numberOfTrees;
            }

            return multiplier;
        }
    }
}