public class Card
{
  public string Name {get; init;}
  public string Description { get; init;}

  public int Attack { get; init;}
  public int Defense { get; init;}
  

  //other methods
  public string GetAsString()
  {
    var cardWidth = 40;
    var output = "";
    for (int i = 0; i < cardWidth; i++)
    {
      output += "-";
    }
    output += "\n";

    output += $"        Title: {Name}\n";
    output += $"  Description: \n{Description}\n";
    output += $"       Attack: {Attack}\n";
    output += $"      Defense: {Defense}\n";
    return output;
  }
}