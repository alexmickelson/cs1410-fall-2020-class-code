public class Sieve
{
  private readonly Func<int, bool> evaluationFunction;

  public Sieve(Func<int, bool> evaluationFunction)
  {
    this.evaluationFunction = evaluationFunction;
  }
  public bool IsGood(int number)
  {
    return evaluationFunction(number);
  }
}