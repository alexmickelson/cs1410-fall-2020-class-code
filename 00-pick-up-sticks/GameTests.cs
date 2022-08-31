using System.Diagnostics;

class GameTests
{
  public void RunTests()
  {
    TestGameStatusAsString();
    // TestPlayerPicksUpSticks();
    TestValidateUserInput();
    // TestIsOver();
    // TestGetEndResult();
  }

  public void TestGameStatusAsString()
  {
    var game = new Game();
    var gameStatus = game.GetStatusAsString();
    var expectedStatus = "there are 10 sticks, it is player one's turn";
    System.Console.WriteLine(gameStatus);
    Debug.Assert(expectedStatus == gameStatus);
  }
  public void TestPlayerPicksUpSticks()
  { 
  }
  public void TestValidateUserInput()
  {
    var game = new Game();
    Debug.Assert(game.ValidateUserInput("10"));
    Debug.Assert(game.ValidateUserInput("not ten") == false);
  }

  public void TestIsOver()
  {
  }

  public void TestGetEndResult()
  {
  }
}