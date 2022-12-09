namespace Recurs;
// 1. Trust the black magic
// 2. handle the base case
// 3. do the rest of the function (is 1 iterative step)

public class Recursion
{
  public static int FibAtIndex(int index, Dictionary<int, int>? pastSolution = null)
  {
    if (pastSolution == null)
      pastSolution = new Dictionary<int, int>();

    System.Console.WriteLine($"Caculating FIB of {index}");

    if (pastSolution.ContainsKey(index))
      return pastSolution[index];

    if (index == 0)
    {
      pastSolution[index] = 0;
      return 0;
    }
    if (index == 1)
    {
      pastSolution[index] = 1;
      return 1;
    }

    var solution = FibAtIndex(index - 1, pastSolution) + FibAtIndex(index - 2, pastSolution);
    pastSolution[index] = solution;

    return solution;
  }

  public static int RecursiveSum(IEnumerable<int> inputList)
  {
    if(inputList.Count() == 0)
      return 0;

    return inputList.ElementAt(0) + RecursiveSum(inputList.Skip(1));
  }
}
