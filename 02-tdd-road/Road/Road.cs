using System.Collections.Generic;
public class Road
{
  public List<Car> cars;
  private int[][] RoadGrid;
  public Road(int width, int length)
  {
    cars = new List<Car>();
    RoadGrid = initializeEmtpyGrid(width, length);
  }
  public int[][] GetRoadGrid()
  {
    var duplicateGrid = initializeEmtpyGrid(getMyWidth(), getMyLength());
    for (int i = 0; i < RoadGrid.Length; i++)
    {
      for (int j = 0; j < RoadGrid[i].Length; j++)
      {
        duplicateGrid[i][j] = RoadGrid[i][j];
      }
    }
    return duplicateGrid;
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
        if (carId == -1)
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
    if (x >= getMyWidth())
    {
      throw new Exception($"Cannot add car: col {x} is larger than or equal to {getMyWidth()}");
    }
    if (y >= getMyLength())
    {
      throw new Exception($"Cannot add car: row {y} is larger than or equal to {getMyWidth()}");
    }
    cars.Add(car);
    var carRow = RoadGrid[y];
    carRow[x] = car.GetId();
    return (car, carRow);
  }

  private Car getCar(int carId)
  {
    foreach (var car in cars)
    {
      if (car.GetId() == carId)
        return car;
    }
    throw new Exception($"no car found with id {carId}");
  }

  public void ProcessTick()
  {
    var nextRoadGrid = initializeEmtpyGrid(getMyWidth(), getMyLength());
    for (int row = 0; row < RoadGrid.Length; row++)
    {
      for (int col = 0; col < RoadGrid[row].Length; col++)
      {
        var carId = RoadGrid[row][col];
        if (carId != -1)
        {
          var car = getCar(carId);
          var carSpeed = car.Speed;
          var nextRow = carSpeed + row;

          if(nextRow < nextRoadGrid.Length)
          {
            nextRoadGrid[nextRow][col] = carId;
          }
        }
      }
    }
    RoadGrid = nextRoadGrid;
  }
}