using System.Collections.Generic;
public class Road
{
  public List<Car> cars;
  public int[][] RoadGrid;
  public Road(int width, int length)
  {
    cars = new List<Car>();
    var row = new int[width];

    for (int i = 0; i < row.Length; i++)
    {
      row[i] = -1;
    }

    RoadGrid = new int[length][];
    for (int i = 0; i < length; i++)
    {
      RoadGrid[i] = row;
    }
  }

  public Road CopyMyself()
  {
    return new Road(getMyWidth(), getMyLength());
  }

  private int getMyWidth()
  {
    return RoadGrid[0].Length;
  }

  private int getMyLength()
  {
    return RoadGrid.Length;
  }

  public int GetArea()
  {
    return getMyLength() * getMyWidth();
  }

  public string GetAsSring()
  {
    var oneSpace = "  |";
    var output = @"
";
    foreach (var carRow in RoadGrid)
    {
      var rowOutput = "|";

      foreach (var carId in carRow)
      {
        if(carId == -1)
        {
          rowOutput += oneSpace;
        } 
        else
        {
          var car = getCar(carId);

          var emojiArray = new string[] {
            "🚙", "🚗", "🚒", "🚑", "🛻"
          };
          var carIndex = (int)car.Icon;
          rowOutput += $"{emojiArray[carIndex]}|";
        }
      }
      rowOutput += "\n";
      output += rowOutput;
    }
    return output;
  }

  public void AddCar(Car car, int x, int y)
  {
    cars.Add(car);
    RoadGrid[y][x] = car.GetId();
  }

  private Car getCar(int carId)
  {
    foreach(var car in cars)
    {
      if(car.GetId() == carId)
        return car;
    }
    throw new Exception($"no car found with id {carId}");
  }

  public void ProcessTick()
  {
    // take each car and move 
    // (according to speed) to its new position
    // var newpositions = Array[]

    var nextRoadGrid = new int[][] { };
  }
}