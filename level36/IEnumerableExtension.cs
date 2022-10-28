public static class IEnumerableExtension
{

  public static IEnumerable<K> TransformEachItemInList<T, K>(
    this IEnumerable<T> inputList,
    Func<T, K> transformation
  )
  {
    var newList = new List<K>();
    foreach (var i in inputList)
    {
      newList.Add(transformation(i));
    }
    return newList;
  }
}