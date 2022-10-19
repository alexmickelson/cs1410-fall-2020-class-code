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
      output += $"|{paddedEmpty} {paddedDescriptionCurrentLine} |\r\n";
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
        lines.Add(word);
      } else 
      {
        
      }
    }
    return String.Join("\r\n", lines);
  }
}