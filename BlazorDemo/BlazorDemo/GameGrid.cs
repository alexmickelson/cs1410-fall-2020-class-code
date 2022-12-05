public class GameGrid
{
  public List<List<int>> Grid { get; set; } = new List<List<int>>()
  {
    new List<int>() { 0, 0, 0 },
    new List<int>() { 0, 0, 0 },
    new List<int>() { 0, 0, 0 },
    new List<int>() { 0, 0, 0 },
  };

  public int PlayerCol { get; set; } = 1;
  public int PlayerRow { get; set; } = 0;

  public GameGrid()
  {
    drawGrid();
  }


  public enum Direction
  {
    Up,
    Down,
    Left,
    Right
  }

  public void MoveDirection(Direction input)
  {
    if (input == Direction.Up) PlayerRow--;
    if (input == Direction.Down) PlayerRow++;
    if (input == Direction.Left) PlayerCol--;
    if (input == Direction.Right) PlayerCol++;

    drawGrid();
  }

  private void drawGrid()
  {
    for (var col = 0; col < Grid[0].Count(); col++)
    {
      for (int row = 0; row < Grid.Count(); row++)
      {
        if (col == PlayerCol && row == PlayerRow)
        {
          Grid[row][col] = 1;
        }
        else
        {
          Grid[row][col] = 0;
        }
      }
    }
  }
}