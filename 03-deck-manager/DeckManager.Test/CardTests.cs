namespace DeckManager.Test;

public class CardTests
{

  [Test]
  public void TestCardString()
  {
    var duckCard = new Card(1)
    {
      Name = "duck",
      Description = "Has a beak\n and flippers",
    };
    var expectedString = @"
----------------------------------------
|       Title: duck                    |
| Description: Has a beak              |
|              and flippers            |
----------------------------------------";
    Assert.AreEqual(expectedString, duckCard.GetAsString());
  }
}