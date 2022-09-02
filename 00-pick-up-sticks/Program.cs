
var tester = new GameTests();
tester.RunTests();

var game = new Game();

while (!game.IsOver())
{
  System.Console.WriteLine(game.GetStatusAsString());

  System.Console.WriteLine("How many sticks would you like to pick up?");
  var userInput = Console.ReadLine();
  int parsedUserInput = -1;

  var again = false;
  while (again)
  {
    try
    {
      parsedUserInput = game.ParseUserInput(userInput);
      again = false;
    }
    catch (Exception e)
    {
      Console.WriteLine("Invalid input please enter a numeric value");
      userInput = Console.ReadLine();
      again = true;
    }
  }


  game.CurrentPlayerPicksUpSticks(parsedUserInput);

  // while (!game.ValidateUserInput(userInput))
  // {
  //   System.Console.WriteLine("Please Try Again");
  //   userInput = Console.ReadLine();
  // }
}

System.Console.WriteLine(game.GetEndResult());
