public class Card
{
  public string Name { get; init; }
  public string Description { get; init; }

  public int Cost { get; }
  protected string lowerPartOfCard { get; set; } = "";

  public Card(int cost)
  {
    if (cost < 0)
      throw new Exception("cost cannot be negative");
    Cost = cost;
  }


  public string GetAsString()
  {
    var cardWidth = 40;
    var output = "\r\n";
    for (int i = 0; i < cardWidth; i++)
    {
      output += "-";
    }
    output += "\r\n";

    output += $"|       Title: {Name}                    |\r\n";
    output += $"| Description: {Description.Split("\n")[0]}              |\r\n";
    output += $"|             {Description.Split("\n")[1]}            |\r\n";
    output += lowerPartOfCard;
    for (int i = 0; i < cardWidth; i++)
    {
      output += "-";
    }
    return output;
  }

}