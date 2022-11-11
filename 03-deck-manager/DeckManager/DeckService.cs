using System.Globalization;
using CsvHelper;

public class DeckService
{
  public static void WriteDeckToFile(string path, IEnumerable<Card> deck)
  {

    var deckOfStorageCars = deck.Select(c => {
      if (c.GetType() == typeof(CreatureCard))
        return new CardStorage(c as CreatureCard);

      if (c.GetType() == typeof(MoneyCard))
        return new CardStorage(c as MoneyCard);

      return null;
    });

    using (var writer = new StreamWriter(path))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
      csv.WriteRecords(deckOfStorageCars);
    }
  }

  public static IEnumerable<Card> ReadDeckFromFile(string path)
  {
    using (var reader = new StreamReader(path))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
      var deck = csv.GetRecords<CardStorage>();
      return deck.Select(c =>
      {
        if (c.TypeOfCard == CardStorage.CardType.Creature)
          return c.GetAsCreature();
        if (c.TypeOfCard == CardStorage.CardType.Money)
          return c.GetAsMoney();

        throw new Exception("card type not valid: " + c.TypeOfCard);
      }).ToArray();
    }
  }
}