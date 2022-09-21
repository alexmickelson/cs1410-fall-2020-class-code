namespace RoadT.Test;

public class CarTests
{
  [Test]
  public void CheckIdProperty()
  {
    var car = new Car();
    try
    {
      car.Id = -50;
      Assert.Fail();
    }
    catch(Exception e)
    {
      // Assert.Fail();
      Assert.AreEqual("Invalid ID", e.Message);
    }
  }

  [Test]
  public void checkIdWorks()
  {
    var car = new Car();
    car.Id = 10;
    Assert.AreEqual(10, car.Id);
  }
}