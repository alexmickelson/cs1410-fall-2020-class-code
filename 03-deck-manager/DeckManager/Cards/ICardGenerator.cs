public interface ICardGenerator
{
  Card[] GenerateDeck(int size);
}

public interface IOtherInterfaces
{
  List<Card> GenerateDeck(int size);
}