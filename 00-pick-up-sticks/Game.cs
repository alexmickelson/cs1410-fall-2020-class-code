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

  internal bool ValidateUserInput(string? userInput)
  {
    return int.TryParse(userInput, out _);
  }

  public bool IsOver()
  {
    return RemainingSticks == 0;
  }

  public void CurrentPlayerPicksUpSticks(int stickCount)
  {
    RemainingSticks -= stickCount;
    if(CurrentPlayer == "player one")
    {
      CurrentPlayer = "player two";
    }
    else 
    {
      CurrentPlayer = "player one";
    }
  }

  public string GetEndResult()
  {
    return $"{CurrentPlayer} won!";
  }
}