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

  [Test]
  public void CanAddCreaturesTogether()
  {
    var creature1 = new CreatureCard(1, 2)
    {
      Name = "first",
      Description = "first"
    };
    var creature2 = new CreatureCard(1, 2)
    {
      Name = "second",
      Description = "second"
    };

    var actualCreature = creature1 + creature2;

    Assert.AreEqual("first second", actualCreature.Name);
    Assert.AreEqual("first second", actualCreature.Description);
    Assert.AreEqual(2, actualCreature.Attack);
    Assert.AreEqual(4, actualCreature.Defense);
  }

  [Test]
  public void CanAddCreatureAndOtherCardTogether()
  {
    var creature = new CreatureCard(1, 2)
    {
      Name = "first",
      Description = "first"
    };
    var money = new MoneyCard()
    {
      Name = "second",
      Description = "second"
    };

    var actualCreature = creature + money;

    Assert.AreEqual("first second", actualCreature.Name);
    Assert.AreEqual("first second", actualCreature.Description);
    Assert.AreEqual(1, actualCreature.Attack);
    Assert.AreEqual(2, actualCreature.Defense);
  }
  [Test]
  public void CanCastMoneyToCreature()
  {
    var money = new MoneyCard()
    {
      Name = "second",
      Description = "second"
    };

    CreatureCard creature = (CreatureCard)money;

    Assert.AreEqual("second", creature.Name);
    Assert.AreEqual("second", creature.Description);
    Assert.AreEqual(0, creature.Attack);
    Assert.AreEqual(0, creature.Defense);
  }
}