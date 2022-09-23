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

  // public static int CheckIfRunning(Road otherRoad)
  // {
  //   otherRoad.RoadGrid = new int[][] { };
  //   return 1;
  // }

  public int[][] GetRoadGrid()
  {
    var duplicateGrid = initializeEmtpyGrid(Width, getMyLength());
    for (int i = 0; i < RoadGrid.Length; i++)
    {
      for (int j = 0; j < RoadGrid[i].Length; j++)
      {
        duplicateGrid[i][j] = RoadGrid[i][j];
      }
    }
    return duplicateGrid;
  }

  public static int[][] initializeEmtpyGrid(int width, int length)
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

  //doesn't do much
  public static Road AddTwoRoads(Road road1, Road road2)
  {
    return new Road(1, 1);
  }

  public Road(int width, int length, Car car, string[] mystring) : this(width, length)
  {
    mystring[1] = "hello";
    car.Id = 2;
    cars.Add(car);
    width = 2;
  }

  public Road CopyMyself()
  {
    return new Road(Width, getMyLength());
  }

  public int Width
  {
    set
    {
      var newArray = initializeEmtpyGrid(value, getMyLength());
      for (int row = 0; row < RoadGrid.Length; row++)
      {
        for (int col = 0; col < RoadGrid[row].Length; col++)
        {
          newArray[row][col] = RoadGrid[row][col];
        }
      }
      RoadGrid = newArray;
    }
    get
    {
      return RoadGrid[0].Length;
    }
  }

  public int Length
  {
    set
    {
      if (value > getMyLength())
      {
        var newArray = initializeEmtpyGrid(Width, getMyLength());
        for (int row = 0; row < RoadGrid.Length; row++)
        {
          for (int col = 0; col < RoadGrid[row].Length; col++)
          {
            newArray[row][col] = RoadGrid[row][col];
          }
        }
        RoadGrid = newArray;
      }
    }
    get { return RoadGrid.Length; }
  }
  private int getMyLength()
  {
    return RoadGrid.Length;
  }

  // private int[] randomNumbers = {1, 2, 3, 4};
  // public int RandomNumber
  // {
  //   get { return randomNumbers[1]; }
  // }
  // public int[] RandomNumbers { get; set; }

  public int GetArea()
  {
    return getMyLength() * Width;
  }

  public string GetAsString()
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

          // var emojiArray = new string[] {
          //   "🚙", "🚗", "🚒", "🚑", "🛻"
          // };
          // var carIndex = car.Icon;
          rowOutput += $"{car.Icon}|";
        }
      }
      rowOutput += "\n";
      output += rowOutput;
    }
    return output;
  }

  public (Car, int[]) AddCar(Car car, int x, int y)
  {
    if (x >= Width)
    {
      throw new Exception($"Cannot add car: col {x} is larger than or equal to {Width}");
    }
    if (y >= getMyLength())
    {
      throw new Exception($"Cannot add car: row {y} is larger than or equal to {Width}");
    }
    cars.Add(car);
    var carRow = RoadGrid[y];
    carRow[x] = car.Id;
    return (car, carRow);
  }

  private Car getCar(int carId)
  {
    foreach (var car in cars)
    {
      if (car.Id == carId)
        return car;
    }
    throw new Exception($"no car found with id {carId}");
  }

  public void ProcessTick()
  {
    var nextRoadGrid = initializeEmtpyGrid(Width, getMyLength());
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

          if (nextRow < nextRoadGrid.Length)
          {
            nextRoadGrid[nextRow][col] = carId;
          }
        }
      }
    }
    RoadGrid = nextRoadGrid;
  }
}