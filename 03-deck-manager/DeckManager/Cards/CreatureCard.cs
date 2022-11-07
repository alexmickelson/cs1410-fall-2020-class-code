public record CreatureCard : Card
{
  public int Attack { get; init; }
  public int Defense { get; init; }

  public CreatureCard() : this(1, 1, 1)
  {

  }

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

  public static CreatureCard operator +(
    CreatureCard a,
    CreatureCard b
  )
  {
    return new CreatureCard()
    {
      Name = a.Name + " " + b.Name,
      Description = a.Description + " " + b.Description,
      Attack = a.Attack + b.Attack,
      Defense = a.Defense + b.Defense,
    };
  }
  public static CreatureCard operator +(
    CreatureCard a,
    Card b
  )
  {
    return new CreatureCard()
    {
      Name = a.Name + " " + b.Name,
      Description = a.Description + " " + b.Description,
    };
  }
  public static implicit operator CreatureCard(MoneyCard card)
  {
    return new CreatureCard()
    {
      Name = card.Name,
      Description = card.Description,
      Attack = 0,
      Defense = 0,
    };
  }
}