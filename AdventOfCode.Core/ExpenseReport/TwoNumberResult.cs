namespace AdventOfCode.Core.ExpenseReport
{
   public record TwoNumberResult(int Number1, int Number2)
   {
      public int TotalExpenses => Number1 * Number2;
   }
}