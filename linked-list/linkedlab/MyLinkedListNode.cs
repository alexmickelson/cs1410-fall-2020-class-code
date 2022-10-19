public class MyLinkedListNode<T>
{
  public T Data { get; init; }
  public MyLinkedListNode<T>? Next { get; set; }

  public MyLinkedListNode(T data)
  {
    Data = data;
  }
}