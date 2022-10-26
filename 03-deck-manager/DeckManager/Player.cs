public class Player
{
  public string Name { get; }
  public List<Card> Deck { get; }

  public List<Card> CardsOnBoard { get; set; } = new();
  public Player(string name, List<Card> deck)
  {
    Name = name;
    Deck = deck;
  }

}