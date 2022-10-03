namespace DeckManager.Test;

public class CardTests
{

  [Test]
  public void TestCardString()
  {
    var duckCard = new Card()
    {
      Name = "duck",
      Description = "Has a beak\n and flippers",
      Attack = 10,
      Defense = 5
    };
    var expectedString = @"
----------------------------------------
|       Title: duck                    |
| Description: Has a beak              |
|              and flippers            |
|      Attack: 10                      |
|     Defense: 5                       |
----------------------------------------";
    Assert.AreEqual(expectedString, duckCard.GetAsString());
  }
}