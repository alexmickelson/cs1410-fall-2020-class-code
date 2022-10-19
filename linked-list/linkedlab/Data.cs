// public struct DataValue
// {
//   public int ID { get; init; }
//   public string Message { get; init; }
// }

public record DataValue
(
  int ID,
  string Message
);