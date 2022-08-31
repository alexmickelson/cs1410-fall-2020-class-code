using System.Diagnostics;

class GameTests
{
  public void RunTests()
  {
    TestGameStatusAsString();
    TestPlayerPicksUpSticks();
    TestValidateUserInput();
    TestIsOver();
    TestGetEndResult();
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
    var game = new Game();
    game.CurrentPlayerPicksUpSticks(10);
    Debug.Assert(game.RemainingSticks == 0);
    Debug.Assert(game.CurrentPlayer == "player two");
  }
  public void TestValidateUserInput()
  {
    var game = new Game();
    Debug.Assert(game.ValidateUserInput("10"));
    Debug.Assert(game.ValidateUserInput("not ten") == false);
  }
  public void TestIsOver()
  {
    var game = new Game();

    Debug.Assert(!game.IsOver());
    game.CurrentPlayerPicksUpSticks(10);
    Debug.Assert(game.IsOver());
  }

  public void TestGetEndResult()
  {
    var game = new Game();
    game.CurrentPlayerPicksUpSticks(10);
    var expectedEndMessage = "player two won!";
    Debug.Assert(expectedEndMessage == game.GetEndResult());
  }
}