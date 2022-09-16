
Console.WriteLine("This program will simulate a road");
// Console.ReadLine();
var car = new Car();
car.SetId(1);
var width = 1;
var mystring = "string";
var myArray = new string[] { "one", "two" };
var road = new Road(width, 1, car, myArray);

System.Console.WriteLine(myArray[1]);


var carTuple = (id: 1, icon: Car.CarIcon.Ambulance, speed: 2);

var other = carTuple.Item1;
// var (id, _, _) = carTuple;

// System.Console.WriteLine(carTuple);


