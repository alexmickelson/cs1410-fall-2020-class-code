public abstract record Card
{
  public Guid Id { get; } = Guid.NewGuid();
  public string Name { get; init; }
  public string Description { get; init; }

  public int Cost { get; }

  public Card(int cost)
  {
    if (cost < 0)
      throw new Exception("cost cannot be negative");
    Cost = cost;
  }

  public override string ToString()
  {
    var cardWidth = 40;
    var output = "\r\n";
    for (int i = 0; i < cardWidth; i++)
    {
      output += "-";
    }
    output += "\r\n";

    var lineBreakDescription = SplitDescriptionBy20Characters();

    var leftPad = 12;
    var rightPad = 24;
    var paddedTitle = "Title".PadLeft(leftPad);
    var paddedDescription = "Description".PadLeft(leftPad);
    var paddedEmpty = "".PadLeft(leftPad);

    var paddedName = Name.PadRight(rightPad);
    var paddedDescriptionFirstLine = lineBreakDescription.Split("\n")[0].PadRight(rightPad);
    output += $"|{paddedTitle}: {paddedName}|\r\n";
    output += $"|{paddedDescription}: {paddedDescriptionFirstLine}|\r\n";

    for (int i = 1; i < lineBreakDescription.Split("\n").Length; i++)
    {
      var paddedDescriptionCurrentLine = lineBreakDescription.Split("\n")[i].PadRight(rightPad);
      output += $"|{paddedEmpty}  {paddedDescriptionCurrentLine}|\r\n";
    }

    for (int i = 0; i < cardWidth; i++)
    {
      output += "-";
    }
    return output;
  }

  public string SplitDescriptionBy20Characters()
  {
    var words = Description.Split(" ");
    var lines = new List<string>() { "" };
    var currentLine = 0;

    foreach (var word in words)
    {
      var lineWouldBeTooBig = (lines[currentLine].Length + word.Length) > 20;
      if (lineWouldBeTooBig)
      {
        currentLine += 1;
        lines.Add(word + " ");
      }
      else
      {
        lines[currentLine] += word + " ";
      }
    }
    return String.Join(Environment.NewLine, lines);
  }
}

public static class CardExtensions
{
  public static string HorizontalString(this List<Card> deck)
  {
    List<List<string>> cardsAsStringArrays = GetCardsAsStringArray(deck);

    int heightOfTallestCard = getHeightOfTallestCard(cardsAsStringArrays);

    var output = "";
    for (int i = 0; i < heightOfTallestCard; i++)
    {
      // output whole row of cards
      output = getRowAsString(cardsAsStringArrays, output, i);

    }
    return output;
  }

  private static string getRowAsString(List<List<string>> cardsAsStringArrays, string output, int i)
  {
    foreach (var card in cardsAsStringArrays)
    {
      if (card.Count() > i)
      {
        output += card[i] + " ";
      }
      else
      {
        output += "                                         ";
      }
    }

    output += "\r\n";
    return output;
  }

  private static List<List<string>> GetCardsAsStringArray(List<Card> deck)
  {
    var cardsAsStringArrays = new List<List<string>>() { };

    foreach (var card in deck)
    {
      var cardString = card.ToString();
      var cardSplitByNewLine = cardString.Split("\r\n").ToList();

      cardsAsStringArrays.Add(cardSplitByNewLine);
    }

    return cardsAsStringArrays;
  }

  private static int getHeightOfTallestCard(List<List<string>> cardsAsStringArrays)
  {
    var heightOfTallestCard = 0;

    foreach (var card in cardsAsStringArrays)
    {
      if (card.Count() > heightOfTallestCard)
      {
        heightOfTallestCard = card.Count();
      }
    }

    return heightOfTallestCard;
  }
}