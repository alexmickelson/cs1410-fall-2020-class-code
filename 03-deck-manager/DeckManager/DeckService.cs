using System.Globalization;
using CsvHelper;

public class DeckService
{
  public static void WriteDeckToFile(string path, IEnumerable<Card> deck)
  {
    using (var writer = new StreamWriter(path))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
      csv.WriteRecords(deck);
    }
  }

  public static IEnumerable<Card> ReadDeckFromFile(string path)
  {
    using (var reader = new StreamReader(path))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
      var deck = csv.GetRecords<Card>();
      return deck.ToArray();
    }
  }
}