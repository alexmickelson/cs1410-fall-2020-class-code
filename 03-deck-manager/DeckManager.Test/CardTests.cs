namespace DeckManager.Test;

public class CardTests : Object
{
  [Test]
  public void TestCardString()
  {
    var duckCard = new CreatureCard(10, 5)
    {
      Name = "duck",
      Description = "Has a beak and flippers, also likes to swim",
    };
    var expectedString = @"
----------------------------------------
|       Title: duck                    |
| Description: Has a beak and          |
|              flippers, also likes    |
|              to swim                 |
|      Attack: 10                      |
|     Defense: 5                       |
----------------------------------------";
    Assert.AreEqual(expectedString, duckCard.ToString());
  }
}