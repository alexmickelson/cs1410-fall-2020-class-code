namespace Recurs.Test;

public class Tests
{


  [Test]
  public void FibTests()
  {
    // Assert.AreEqual(0, Recursion.FibAtIndex(0));
    // Assert.AreEqual(1, Recursion.FibAtIndex(1));
    // Assert.AreEqual(1, Recursion.FibAtIndex(2));
    Assert.AreEqual(2, Recursion.FibAtIndex(3));
    // Assert.AreEqual(144, Recursion.FibAtIndex(12));

  }
}