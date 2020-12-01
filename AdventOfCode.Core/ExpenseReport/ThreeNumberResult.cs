namespace AdventOfCode.Core.ExpenseReport
{
    public record ThreeNumberResult(int Number1, int Number2, int Number3)
        : TwoNumberResult(Number1, Number2)
    {
        public int TotalExpense => base.TotalExpenses * Number3;
    }
}