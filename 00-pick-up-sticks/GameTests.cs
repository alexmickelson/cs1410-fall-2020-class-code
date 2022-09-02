using System.Diagnostics;

class GameTests
{
  public void RunTests()
  {
    TestGameStatusAsString();
    // TestPlayerPicksUpSticks();
    TestValidateValidUserInput();
    TestInvalidTextThrowsError();
    // TestIsOver();
    // TestGetEndResult();
  }

  public void TestGameStatusAsString()
  {
    var game = new Game();
    var gameStatus = game.GetStatusAsString();
    var expectedStatus = "there are 10 sticks, it is player one's turn";
    // System.Console.WriteLine(gameStatus);
    Debug.Assert(expectedStatus == gameStatus);
  }
  public void TestPlayerPicksUpSticks()
  {
  }
  public void TestValidateValidUserInput()
  {
    var game = new Game();
    var parsedInput = game.ParseUserInput("2");
    Debug.Assert(parsedInput == 2);
  }
  public void TestInvalidTextThrowsError()
  {
    var game = new Game();
    try
    {
      var parsedInput = game.ParseUserInput("none");
      Debug.Assert(false);
    }
    catch (Exception e)
    {
      var expectedMessage = "Invalid user input, cannot parse as int, input was: none";
      Debug.Assert(e.Message == expectedMessage, "check that thrown error is correct");
    }
  }

  public void TestIsOver()
  {
  }

  public void TestGetEndResult()
  {
  }
}