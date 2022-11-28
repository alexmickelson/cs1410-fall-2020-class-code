public class GameGrid
{
  public List<List<int>> Grid { get; set; } = new List<List<int>>()
  {
    new List<int>() { 0, 1, 0},
    new List<int>() { 0, 0, 0},
    new List<int>() { 0, 0, 0},
    new List<int>() { 0, 0, 0},
  };
  public int X { get; set; } = 1;
  public int Y { get; set; } = 0;


  public enum Direction
  {
    Up,
    Down,
    Left,
    Right
  }
  public void MoveDirection(Direction input)
  {

    if (input == Direction.Up)
    {
      Y--;
    }
    if (input == Direction.Down)
    {
      Y++;
    }

    for (var i = 0; i < Grid[0].Count(); i++)
    {
      for (int j = 0; j < Grid.Count(); j++)
      {
        if (i == X && j == Y)
        {
          Grid[i][j] = 1;
        }
        else
        {
          Grid[i][j] = 0;
        }
      }
    }
  }
}