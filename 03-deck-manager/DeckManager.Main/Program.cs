// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var mylist = new List<Card>() { };
Card? mySelectedCard = FindCardByName(mylist, "duck");

// if (mySelectedCard == null)
// {
//   // do null things 
//   System.Console.WriteLine("No card found");
// }
// else
// {
//   // do not null things
//   System.Console.WriteLine($"Your cards attack is {mySelectedCard.Attack}");
// }


EndProgramIfNull(mySelectedCard);

string nullMessage = "--card not found--";
// System.Console.WriteLine($"your attack is {mySelectedCard?.Attack.ToString() ?? nullMessage}");
System.Console.WriteLine($"your attack is {mySelectedCard!.Attack.ToString()}");

// Card otherCard = FindCardByName(mylist, "duck") ?? throw new Exception("card not found");



// Card? mycard = null;
// Card? mycard2 = null;

// System.Console.WriteLine(mycard == mycard2);

Card? FindCardByName(List<Card> list, string name)
{
  foreach (var card in list)
  {
    if (card.Name == name)
    {
      return card;
    }
  }
  // throw new Exception("")
  return null;
}

void EndProgramIfNull(Card? theCard)
{
  var _ = theCard ?? throw new Exception("not found");
}