

public class Car
{
  public enum CarIcon
  {
    BlueCar,
    RedCar,
    Firetruck,
    Ambulance,
    RedTruck,
  }
  private int Id;
  public CarIcon Icon; //🚙 🚗 🚒 🚑 🛻 🚚
  public int Speed; // Tiles per second

  public int GetId()
  {
    return Id;
  }

  public void SetId(int newId)
  {
    if (newId < 0)
    {
      throw new Exception("Invalid ID");
    }
    Id = newId;
  }
}
