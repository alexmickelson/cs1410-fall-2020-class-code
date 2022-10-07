public class CreatureCard : Card
{
  public int Attack { get; }
  public int Defense { get; }

  public CreatureCard(int attack, int defense) : this(attack, defense, 1)
  {
  }

  public CreatureCard(int attack, int defense, int cost) : base(cost)
  {
    this.Attack = attack;
    this.Defense = defense;
  }

  public override string ToString()
  {
    string lowerPartOfCard = "";
    lowerPartOfCard += $"|      Attack: {Attack}                      |\r\n";
    lowerPartOfCard += $"|     Defense: {Defense}                       |\r\n";

    var baseString = base.ToString();
    var baseStringArray = baseString.Split("\r\n");
    baseStringArray[baseStringArray.Length - 1] = lowerPartOfCard + baseStringArray[baseStringArray.Length - 1];


    var newBaseString = String.Join("\r\n", baseStringArray);
    return newBaseString;
  }
}