public record CardStorage
{
  public enum CardType
  {
    Creature,
    Money
  }
  public CardType TypeOfCard { get; init; }
  public int Cost { get; init; }
  public string Name { get; init; }
  public string Description { get; init; }
  public int Attack { get; init; } = -1;
  public int Defense { get; init; } = -1;


  public CardStorage(CreatureCard incoming)
  {
    TypeOfCard = CardType.Creature;
    Cost = incoming.Cost;
    Name = incoming.Name;
    Description = incoming.Description;
    Attack = incoming.Attack;
    Defense = incoming.Defense;
  }
  public CardStorage(MoneyCard incoming)
  {
    TypeOfCard = CardType.Money;
    Cost = incoming.Cost;
    Name = incoming.Name;
    Description = incoming.Description;
  }

  public CreatureCard GetAsCreature()
  {
    return new CreatureCard(Attack, Defense, Cost)
    {
      Name = Name,
      Description = Description
    };
  }
  public MoneyCard GetAsMoney()
  {
    return new MoneyCard(Cost)
    {
      Name = Name,
      Description = Description
    };
  }
}