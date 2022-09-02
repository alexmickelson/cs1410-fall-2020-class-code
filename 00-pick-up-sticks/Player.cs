using System.Diagnostics;

class Player
{
  public string Name = "no name";
  public int Id;

  public Player()
  {
    var rand = new Random();
    Id = rand.Next();

    System.Console.WriteLine("in default constructor");
  }
  public Player(string name)
  {
    if(name == "" )
      throw new Exception("Player Name cannot be empty");
    
    this.Name = name;
  }

  public string GetNameAsString()
  {
    return Name;
  }
}