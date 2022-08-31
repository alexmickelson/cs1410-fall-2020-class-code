using System.Diagnostics;

class GameTests
{
  public static void TestGameStatusAsString() 
  {

    var game = new Game();
    var gameStatus = game.GetStatusAsString();
    var expectedStatus = "there are 10 sticks, it is player one's turn";
    System.Console.WriteLine(gameStatus);
    Debug.Assert(expectedStatus == gameStatus);
  }
}