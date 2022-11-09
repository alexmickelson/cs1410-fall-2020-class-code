using System.Globalization;
using CsvHelper;

public class DeckService
{
  public static void WriteDeckToFile(string path, IEnumerable<Card> deck)
  {
    IEnumerable<CreatureCard> creatures = deck
      .Where(c => c.GetType() == typeof(CreatureCard))
      .Select(c => c as CreatureCard)!;

    using (var writer = new StreamWriter(path))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
      csv.WriteRecords(creatures);
    }
  }

  public static IEnumerable<CreatureCard> ReadDeckFromFile(string path)
  {
    using (var reader = new StreamReader(path))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
      var deck = csv.GetRecords<CreatureCard>();
      return deck.ToArray();
    }
  }
}