class Game
{
  public Player CurrentPlayer;
  public int RemainingSticks = 10;
  public Game()
  {
    CurrentPlayer = new Player("player one");
  }

  public string GetStatusAsString()
  {
    return $"there are {RemainingSticks} sticks, it is {CurrentPlayer.Name}'s turn";
  }

  public int ParseUserInput(string? userInput)
  {
    var isValidInput = int.TryParse(userInput, out _);
    if (!isValidInput)
      throw new Exception($"Invalid user input, cannot parse as int, input was: {userInput}");
    var parsedNumber = int.Parse(userInput);

    if (parsedNumber <= 0)
      throw new Exception("Number has to be positive, non-zero");
    if (parsedNumber > RemainingSticks)
      throw new Exception("number has to be less than remaining sticks");
    if (parsedNumber > 3)
      throw new Exception("number has to be less than four");

    return parsedNumber;
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