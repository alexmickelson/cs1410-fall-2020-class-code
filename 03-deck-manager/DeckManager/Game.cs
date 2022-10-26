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

  public void PlayTurn()
  {
    DrawPhase();
    AttackPhase();
    EndPhase();
  }

  private void DrawPhase()
  {
    Player1.PlayCard();
    Player2.PlayCard();
  }
  private void AttackPhase()
  {
    // players cannot attack without creature card
    // if a player has a creature card on board, it will attac
    // which card is attack
    // is the other player defending
    // what is the outcome

    // player1

    // player2

  }
  private void EndPhase()
  {
    // dead creatures get discarded
  }
}