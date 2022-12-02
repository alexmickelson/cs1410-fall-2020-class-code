namespace BlazorDemo.Test;

public class Tests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void TestGridMovement()
  {
    var gameGrid = new GameGrid();
    gameGrid.MoveDirection(GameGrid.Direction.Down);
    gameGrid.MoveDirection(GameGrid.Direction.Down);

    Assert.AreEqual(1, gameGrid.X);
    Assert.AreEqual(2, gameGrid.Y);
    Assert.AreEqual(1, gameGrid.Grid[1][2]);
  }
}