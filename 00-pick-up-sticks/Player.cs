using System.Diagnostics;

class Player
{
  public string name = "no name";
  public int Id;

  public Player()
  {
    var rand = new Random();
    Id = rand.Next();

    System.Console.WriteLine("in default constructor");
  }
  public Player(string name)
  {
    this.name = name;
  }

  public string GetNameAsString()
  {
    return Name;
  }
}