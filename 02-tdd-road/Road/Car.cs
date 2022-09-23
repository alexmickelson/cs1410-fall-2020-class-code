

public class Car
{
  // public enum CarIcon
  // {
  //   BlueCar,
  //   RedCar,
  //   Firetruck,
  //   Ambulance,
  //   RedTruck,
  // }
  public static class CarIcon
  {
    public static readonly string BlueCar = "🚙";
    public static readonly string RedCar = "🚗";
    public static readonly string Firetruck = "🚒";
    public static readonly string Ambulance = "🚑";
    public static readonly string RedTruck = "🛻";
  }

  public string Icon; //🚙 🚗 🚒 🚑 🛻 🚚
  // public int Speed; // Tiles per second
  private double _speed;
  public int Speed
  {
    get { return (int)_speed; }
    set { _speed = value; }
  }
  
  public Car()
  { }

  public Car(Car otherCar)
  {
    Id = otherCar.Id;
    Icon = otherCar.Icon;
    Speed = otherCar.Speed;
  }

  // public readonly int myFieldOrMyDataMember;

  //These are the same:
  // public int MyProperty { get; set; }
  
  // private int myVar;
  // public int MyProperty
  // {
  //   get { return myVar; }
  //   set { myVar = value; }
  // }
  


  private int _id;
  public int Id
  {
    get { return _id; }
    set
    {
      if (value < 0)
      {
        throw new Exception("Invalid ID");
      }
      _id = value;
    }
  }

  // private int Id;
  // public int GetId()
  // {
  //   return Id;
  // }

  public void SetId(int newId)
  {
    if (newId < 0)
    {
      throw new Exception("Invalid ID");
    }
    Id = newId;
  }
}
