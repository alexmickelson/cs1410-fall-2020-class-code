public record MoneyCard : Card
{
  public int Value { get; init; } = 1;
  public MoneyCard() : base(0)
  {
    
  }
  
  public override string ToString()
  {
    return base.ToString();
  }
}