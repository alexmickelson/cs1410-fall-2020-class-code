using System.Collections.Generic;

public class Road
{
  private Car[][] RoadGrid;

  public event Action TickCompleted;

  public Road(int width, int length)
  {
    RoadGrid = initializeEmtpyGrid(width, length);
  }

  // public static int CheckIfRunning(Road otherRoad)
  // {
  //   otherRoad.RoadGrid = new int[][] { };
  //   return 1;
  // }

  public Car[][] GetRoadGrid()
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

  public static Car[][] initializeEmtpyGrid(int width, int length)
  {
    var grid = new Car[length][];
    for (int i = 0; i < length; i++)
    {
      var row = new Car[width];
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

  public int GetArea()
  {
    return getMyLength() * Width;
  }

  public string GetAsString()
  {
    var output = @"
";
    foreach (var carRow in RoadGrid)
    {
      var rowOutput = "|";
      foreach (var car in carRow)
      {
        rowOutput += $"{car?.Icon ?? "  "}|";
      }
      rowOutput += "\n";
      output += rowOutput;
    }
    return output;
  }

  public void AddCar(Car car, int x, int y)
  {
    if (x >= Width)
    {
      throw new Exception($"Cannot add car: col {x} is larger than or equal to {Width}");
    }
    if (y >= getMyLength())
    {
      throw new Exception($"Cannot add car: row {y} is larger than or equal to {Width}");
    }
    RoadGrid[y][x] = car;
  }

  // private Car getCar(int carId)
  // {
  //   foreach (var car in cars)
  //   {
  //     if (car.Id == carId)
  //       return car;
  //   }
  //   throw new Exception($"no car found with id {carId}");
  // }

  public void ProcessTick()
  {
    lock (this)
    {

      var nextRoadGrid = initializeEmtpyGrid(Width, getMyLength());
      for (int row = 0; row < RoadGrid.Length; row++)
      {
        for (int col = 0; col < RoadGrid[row].Length; col++)
        {
          var car = RoadGrid[row][col];
          if (car != null)
          {
            var carSpeed = car.Speed;
            var nextRow = carSpeed + row;

            if (nextRow < nextRoadGrid.Length)
            {
              nextRoadGrid[nextRow][col] = car;
            }
          }
        }
      }
      RoadGrid = nextRoadGrid;

      TickCompleted?.Invoke();
    }
  }
}