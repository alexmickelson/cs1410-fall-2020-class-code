public record MoneyCard : Card
{
  public int Value { get; init; } = 1;
  public MoneyCard() : base(0)
  {
    
  }
}