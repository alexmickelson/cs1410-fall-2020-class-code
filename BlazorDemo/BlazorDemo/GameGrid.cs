public class GameGrid
{
  public List<List<int>> Grid { get; set; } = new List<List<int>>()
  {
    new List<int>() { 0, 1, 0 },
    new List<int>() { 0, 0, 0 },
    new List<int>() { 0, 0, 0 },
    new List<int>() { 0, 0, 0 },
  };

  public int X { get; set; } = 1;
  public int Y { get; set; } = 0;
  public GameGrid()
  {
    reDrawGrid();
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
    if (input == Direction.Up) Y--;
    if (input == Direction.Down) Y++;
    if (input == Direction.Left) X--;
    if (input == Direction.Right) X++;
    System.Console.WriteLine($"X: {X}, Y: {Y}");
    reDrawGrid();
    System.Console.WriteLine(GridString());
  }

  private void reDrawGrid()
  {
    for (var i = 0; i < Grid[0].Count() - 1; i++)
    {
      for (int j = 0; j < Grid.Count() - 1; j++)
      {
        if (i == X && j == Y)
        {
          Grid[j][i] = 1;
        }
        else
        {
          Grid[j][i] = 0;
        }
      }
    }
  }

  public  string GridString()
  {
    var output = "";
    foreach (var row in Grid)
    {
      foreach (var cell in row)
      {
        output += cell;
      }
      output += Environment.NewLine;
    }
    return output;
  }
}