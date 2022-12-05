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

    Assert.AreEqual(1, gameGrid.PlayerCol);
    Assert.AreEqual(2, gameGrid.PlayerRow);
    Assert.AreEqual(1, gameGrid.Grid[2][1]);
  }

  [Test]
  public void TestGridMovement2()
  {
    var gameGrid = new GameGrid();
    gameGrid.MoveDirection(GameGrid.Direction.Right);

    Assert.AreEqual(2, gameGrid.PlayerCol);
    Assert.AreEqual(0, gameGrid.PlayerRow);
    Assert.AreEqual(1, gameGrid.Grid[0][2]);
  }
}