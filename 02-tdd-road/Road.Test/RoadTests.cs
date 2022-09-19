public class RoadTests
{
  [Test]
  public void CanCreateRoadGridInConstructor()
  {
    var road = new Road(2, 5);
    Assert.AreEqual(10, road.GetArea());
  }

  [Test]
  public void CanRenderRoad()
  {
    var road = new Road(2, 3);
    var expectedRoadString = @"
|  |  |
|  |  |
|  |  |
";
    Assert.AreEqual(expectedRoadString, road.GetAsSring());
    // Debug.Assert(expectedRoadString == road.GetAsSring());
  }

  [Test]
  public void CanRenderRoad2()
  {
    var road = new Road(3, 2);
    var expectedRoadString = @"
|  |  |  |
|  |  |  |
";
    Assert.AreEqual(expectedRoadString, road.GetAsSring());
  }

  [Test]
  public void CanPutCarOnRoad()
  {
    var car = new Car();
    car.SetId(0);
    // car.Icon = "🚗";
    car.Icon = Car.CarIcon.RedCar;
    car.Speed = 1;
    var road = new Road(2, 2);
    road.AddCar(car, 0, 0);

    var expectedRoadString = @"
|🚗|  |
|  |  |
";
    Assert.AreEqual(expectedRoadString, road.GetAsSring());
  }
  [Test]
  public void CanPutCarOnRoadInADifferentSpot()
  {
    var car = new Car();
    car.SetId(0);
    // car.Icon = "🚗";
    car.Icon = Car.CarIcon.RedCar;
    car.Speed = 1;
    var road = new Road(2, 2);
    road.AddCar(car, 1, 0);

    var expectedRoadString = @"
|  |🚗|
|  |  |
";
    Assert.AreEqual(expectedRoadString, road.GetAsSring());
  }

  [Test]
  public void CarsMoveEachTick()
  {
    var car = new Car();
    car.SetId(1);
    car.Icon = Car.CarIcon.RedCar;
    car.Speed = 1;
    var road = new Road(1, 2);
    var (otherCarReference, roadRow) = road.AddCar(car, 0, 0);

    road.ProcessTick();

    var expectedRoadString = @"
|  |
|🚗|
";
    Assert.AreEqual(expectedRoadString, road.GetAsSring());
  }

  [Test]
  public void CorrectCarSpeed()
  {
    var car = new Car();
    car.SetId(1);
    car.Icon = Car.CarIcon.RedCar;
    car.Speed = 2;
    var road = new Road(1, 3);
    var (otherCarReference, roadRow) = road.AddCar(car, 0, 0);

    road.ProcessTick();

    var expectedRoadString = @"
|  |
|  |
|🚗|
";
    Assert.AreEqual(expectedRoadString, road.GetAsSring());
  }
  
  [Test]
  public void TicksWorkWithComplexRoads()
  {
    var explorer = new Car();
    explorer.SetId(1);
    explorer.Icon = Car.CarIcon.RedCar;
    explorer.Speed = 1;
    var mustang = new Car();
    mustang.SetId(2);
    mustang.Icon = Car.CarIcon.BlueCar;
    mustang.Speed = 100;
    var road = new Road(2, 3);
    road.AddCar(explorer, 0, 0);
    road.AddCar(mustang, 0, 1);

    road.ProcessTick();

    var expectedRoadString = @"
|  |  |
|🚗|  |
|  |  |
";

    Assert.AreEqual(expectedRoadString, road.GetAsSring());
  }
}