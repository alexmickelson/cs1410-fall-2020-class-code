public class PlayerDeckIsEmptyException : Exception
{
  public PlayerDeckIsEmptyException(string message) : base(message)
  { }
}