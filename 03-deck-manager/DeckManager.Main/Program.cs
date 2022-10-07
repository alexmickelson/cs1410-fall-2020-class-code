// See https://aka.ms/new-console-template for more information


var mylist = new List<Card>() { 
  new CreatureCard(10, 5) {
    Name="duck",
    Description="Has a beak\n and flippers",
  },
  new MoneyCard() 
  {
    Name="Pond",
    Description="Spend me\n please",
  }
};
var firstCard = mylist[0];
System.Console.WriteLine($"{firstCard}");

if(firstCard is CreatureCard)
{
  System.Console.WriteLine("is a creature");

}
else if(firstCard is MoneyCard)
{
  System.Console.WriteLine("is a money");
}






//Null example
// Card? mySelectedCard = FindCardByName(mylist, "duck");
// EndProgramIfNull(mySelectedCard);
// string nullMessage = "--card not found--";
// System.Console.WriteLine($"your attack is {mySelectedCard!.Attack.ToString()}");
// System.Console.WriteLine(mySelectedCard.GetAsString());


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