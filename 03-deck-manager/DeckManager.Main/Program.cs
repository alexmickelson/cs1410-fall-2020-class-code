using System.Text.Json;
using System.Text.Json.Serialization;



// messingWithQueryExpressions();
// addCreaturesTogether();
testingFiles();

static void messingWithQueryExpressions()
{
  var deck = CardGenerator.GenerateDeck(10, shouldSeedRandom: true);


  var results = deck.Select(c => c.Name);

  var largest = deck
    .Where(c => c.GetType() == typeof(CreatureCard))
    .Select(c => c as CreatureCard)
    .OrderBy(c => c.Attack)
    .First();

  System.Console.WriteLine();

  deck.ToList().ForEach(System.Console.WriteLine);

}

static void deckDictionary()
{
  var deck = CardGenerator.GenerateDeck(2);

  var cardsByName = new Dictionary<string, Card>();

  cardsByName["myFavorite"] = deck[0];
  cardsByName["othercard"] = deck[0];
  cardsByName["myFavorite"] = deck[1];
}

// System.Console.WriteLine(deck.HorizontalString());


// System.Console.WriteLine(JsonSerializer.Serialize(cardsByName));

// foreach(var card in deck)
// {
//   System.Console.WriteLine(card);
// }

// Would you ever want to eat an exception?

static void addCreaturesTogether()
{
  // CardGenerator.GenerateDeck(0, true);
  // var creature1 = CardGenerator.GenerateCreature();
  // var creature2 = CardGenerator.GenerateCreature();

  // var sumCreature = creature1 + creature2;

  // System.Console.WriteLine(creature1);
  // System.Console.WriteLine(creature2);
  // System.Console.WriteLine(sumCreature);
}

static void testingFiles()
{
  var deck = CardGenerator.GenerateDeck(10, true);
  DeckService.WriteDeckToFile("testDeckStorage.txt", deck);
  var deck2 = DeckService.ReadDeckFromFile("testDeckStorage.txt");
  
  deck2
    .ToList()
    .ForEach(System.Console.WriteLine);
}