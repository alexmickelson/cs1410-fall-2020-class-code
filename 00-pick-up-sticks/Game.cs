class Game
{
  public string CurrentPlayer = "player one";
  public int RemainingSticks = 10;
  public Game()
  {
    
  }

  public string GetStatusAsString()
  {
    return $"there are {RemainingSticks} sticks, it is {CurrentPlayer}'s turn";
  }

  public bool ValidateUserInput(string? userInput)
  {
    return int.TryParse(userInput, out _);
  }

  public bool IsOver()
  {
    return false;
  }

  public void CurrentPlayerPicksUpSticks(int stickCount)
  {
  }

  public string GetEndResult()
  {
    return "";
  }
}