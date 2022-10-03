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
    var output = "\r\n";
    for (int i = 0; i < cardWidth; i++)
    {
      output += "-";
    }
    output += "\r\n";

    output += $"|       Title: {Name}                    |\r\n";
    output += $"| Description: {Description.Split("\n")[0]}              |\r\n";
    output += $"|             {Description.Split("\n")[1]}            |\r\n";
    output += $"|      Attack: {Attack}                      |\r\n";
    output += $"|     Defense: {Defense}                       |\r\n";
    for (int i = 0; i < cardWidth; i++)
    {
      output += "-";
    }
    return output;
  }
}