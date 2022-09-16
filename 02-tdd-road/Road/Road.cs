using System.Collections.Generic;
public class Road
{
  public List<Car> cars;
  public int[][] RoadGrid;
  public Road(int width, int length)
  {
    cars = new List<Car>();
    RoadGrid = initializeEmtpyGrid(width, length);
  }

  private int[][] initializeEmtpyGrid(int width, int length)
  {
    var grid = new int[length][];
    for (int i = 0; i < length; i++)
    {
      var row = new int[width];
      for (int j = 0; j < row.Length; j++)
      {
        row[j] = -1;
      }
      grid[i] = row;
    }
    return grid;
  }

  public Road(int width, int length, Car car, string[] mystring) : this(width, length) 
  {
    mystring[1] = "hello";
    car.SetId(2);
    cars.Add(car);
    width = 2;
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

  public (Car, int[]) AddCar(Car car, int x, int y)
  {
    cars.Add(car);
    var carRow = RoadGrid[y];
    carRow[x] = car.GetId();
    return (car, carRow);
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

    var nextRoadGrid = initializeEmtpyGrid(getMyWidth(), getMyLength());

    for (int i = 0; i < RoadGrid.Length; i++)
    {
      for (int j = 0; j < RoadGrid[i].Length; j++)
      {
        var car = getCar(RoadGrid[i][j]);
        var carSpeed = car.Speed;
      }
    }
  }
}