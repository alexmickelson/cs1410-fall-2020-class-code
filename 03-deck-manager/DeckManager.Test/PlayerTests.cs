using NUnit;
public class PlayerTests
{
  [Test]
  public void PlayCardShouldThowExceptionWithEmptyDeck()
  {
    var bob = new Player("Bob", new List<Card>());
    try
    {
      bob.PlayCard();
      Assert.Fail();
    }
    catch (PlayerDeckIsEmptyException)
    {
      Assert.Pass();
    }
  }

  [Test]
  public void TestPlayerCanAttack()
  {
    var deck = new List<Card>() {
      new CreatureCard(10, 10) {
        Name = "testcard", 
        Description = "testdescription"}
    };
    var p = new Player("test", deck);
    p.PlayCard();
    Assert.AreEqual(true, p.PlayerCanAttack);
  }
}