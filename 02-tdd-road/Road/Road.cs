public class Road
{
  public List<Car> cars;
  public int[][] RoadGrid;
  private int area;
  public Road(int width, int length)
  {
    cars = new List<Car>();
    area = width * length;
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

  public int GetArea()
  {
    return area;
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
          rowOutput += $"{car.Icon}|";
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
}