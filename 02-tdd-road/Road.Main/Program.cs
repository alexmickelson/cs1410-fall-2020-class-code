
using System.Diagnostics;

Console.WriteLine("This program will simulate a road");
// Console.ReadLine();
var explorer = new Car();
explorer.Id = 1;
explorer.Speed = 2;
explorer.Icon = Car.CarIcon.Ambulance;

var civic = new Car(explorer);

civic.Speed = 5;
civic.Id = 2;
civic.Icon = Car.CarIcon.BlueCar;
var road = new Road(5, 15);
road.AddCar(explorer, 0, 0);
road.AddCar(civic, 3, 0);

var ticks = DateTime.Now.Ticks;
Console.WriteLine(ticks);

var randomNumberlessThan5 = DateTime.Now.Ticks % 1_000_000;
System.Console.WriteLine(DateTime.Now.Ticks % 5);

var writeRoad = () => System.Console.WriteLine(road.GetAsString());
var otherListener = () => System.Console.WriteLine("other listener");

writeRoad();

road.TickCompleted += writeRoad;
road.TickCompleted += otherListener;


var i = 0;
while (true)
{
  Console.Clear();

  road.ProcessTick();

  Thread.Sleep(500);
  if(i == 5)
  {
    Cleanup();
  }
  i++;
}

void Cleanup()
{
  road.TickCompleted -= otherListener;
}

// var othercar = new Car() { Vin = 12345 };

// var random = new Random();
// var randomNumberlessThan5 = random.Next(5);


// var emptyGrid = Road.initializeEmtpyGrid(2, 2);

// var road1 = new Road(1, 1);
// var road2 = new Road(1, 1);
// var summedRoad = Road.AddTwoRoads(road1, road2);

// System.Console.WriteLine(myArray[1]);


// var carTuple = (id: 1, icon: Car.CarIcon.Ambulance, speed: 2);

// var other = carTuple.Item1;
// // var (id, _, _) = carTuple;

// // System.Console.WriteLine(carTuple);



// var grid = road.GetRoadGrId = );

// grid[2][2] = -100;


