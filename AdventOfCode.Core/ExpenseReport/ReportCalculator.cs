using System;

namespace AdventOfCode.Core.ExpenseReport
{
    public class ReportCalculator
    {
        public const int Total = 2020;
        
        private readonly int[] _expenses;

        public ReportCalculator(int[] expenses) => _expenses = expenses;

        public TwoNumberResult FindTwoNumberResult()
        {
            foreach (var number1 in _expenses)
                foreach (var number2 in _expenses)
                    if (number1 + number2 == Total)
                        return new TwoNumberResult(number1, number2);

            throw new Exception("No numbers found");
        }

        public ThreeNumberResult FindThreeNumberResult()
        {
            foreach (var number1 in _expenses)
                foreach (var number2 in _expenses)
                    foreach(var number3 in _expenses)
                        if (number1 + number2 + number3 == Total)
                            return new ThreeNumberResult(number1, number2, number3); 

            throw new Exception("No numbers found");
        }
    }
}