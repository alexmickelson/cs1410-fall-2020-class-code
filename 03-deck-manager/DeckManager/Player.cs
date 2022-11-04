using System.Collections;

public class Player
{
  public string Name { get; }
  public List<Card> Deck { get; }
  public List<Card> CardsOnBoard { get; } = new();

  public bool PlayerCanAttack
  {
    get
    {
      foreach (var card in CardsOnBoard)
      {
        if(card.GetType() == typeof(CreatureCard))
        {
          return true;
        }
      }
      return false;
    }
  }
  public List<Card> Discard { get; } = new();
  public Player(string name, List<Card> deck)
  {
    Name = name;
    Deck = deck;
  }

  public void PlayCard()
  {
    try
    {
      var nextCard = Deck.First();
      CardsOnBoard.Add(nextCard);
    }
    catch (InvalidOperationException e)
    {
      throw new PlayerDeckIsEmptyException(e.Message);
    }
    Deck.RemoveAt(0);
  }
}