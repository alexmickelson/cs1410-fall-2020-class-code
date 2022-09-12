public class Car
{
  private int Id;
  public string Icon; //🚙 🚗
  public int Speed; // Tiles per second

  public int GetId()
  {
    return Id;
  }

  public void SetId(int newId)
  {
    if(newId < 0)
    {
      throw new Exception("Invalid ID");
    }
    Id = newId;
  }

}