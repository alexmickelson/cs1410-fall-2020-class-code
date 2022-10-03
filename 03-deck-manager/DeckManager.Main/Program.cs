// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var mylist = new List<Card>() { 
  new Card() {
    Name="duck",
    Description="Has a beak\n and flippers",
    Attack=10,
    Defense=5
  },
};
Card? mySelectedCard = FindCardByName(mylist, "duck");


EndProgramIfNull(mySelectedCard);

string nullMessage = "--card not found--";
System.Console.WriteLine($"your attack is {mySelectedCard!.Attack.ToString()}");


System.Console.WriteLine(mySelectedCard.GetAsString());


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