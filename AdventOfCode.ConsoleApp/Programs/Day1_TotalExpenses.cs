using System.IO;
using System.Linq;
using AdventOfCode.Core;
using AdventOfCode.Core.ExpenseReport;

namespace AdventOfCode.ConsoleApp.Programs
{
    public class Day1_TotalExpenses : ProgramBase
    {
        private readonly ReportCalculator _expenseCalculator;

        public Day1_TotalExpenses()
        {
            var input = File.ReadAllLines("Input/day1.txt").Select(int.Parse).ToArray();
            _expenseCalculator = new ReportCalculator(input);
        }

        public override void RunExercise1()
        {
            var twoNumberResult = _expenseCalculator.FindTwoNumberResult();
            LogMessage(twoNumberResult.ToString());
        }

        public override void RunExercise2()
        {
            var threeNumberResult = _expenseCalculator.FindThreeNumberResult();
            LogMessage(threeNumberResult.ToString());
        }
    }
}