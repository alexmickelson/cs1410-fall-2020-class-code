public class CreatureCard : Card
{
  public int Attack { get; }
  public int Defense { get; }

  public CreatureCard(int attack, int defense) : this(attack, defense, 1)
  {
  }

  public CreatureCard(int attack, int defense, int cost) : base(cost)
  {
    Attack = attack;
    Defense = defense;
    lowerPartOfCard += $"|      Attack: {Attack}                      |\r\n";
    lowerPartOfCard += $"|     Defense: {Defense}                       |\r\n";
  }
}