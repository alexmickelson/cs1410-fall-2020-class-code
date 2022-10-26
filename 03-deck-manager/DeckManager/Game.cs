public class Game
{
  public Player Player1 { get; }
  public Player Player2 { get; }

  public static (K, T) CreatureFight<K, T>(K attacker, T defender)
  {
    return (attacker, defender);
  }
  public Game(Player player1, Player player2)
  {
    Player1 = player1;
    Player2 = player2;
  }

  

}