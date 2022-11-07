using System.Collections;

// {}
// []
// <>
public class MyList<T> : IEnumerable<T>
{
  public T this[int index]
  {
    get {
      var enumerator = GetEnumerator();
      for (int i = 0; i < index; i++)
      {
        enumerator.MoveNext();
      }
      return (T) enumerator.Current;
    }
  }
  public MyLinkedListNode<T>? Head { get; set; }
  public int Count
  {
    get
    {
      var counter = 0;
      var current = Head;
      while (current != null)
      {
        counter++;
        current = current.Next;
      }
      return counter;
    }
  }
  public MyList(T[] startingArray)
  {
    MyLinkedListNode<T>? previous = null;
    foreach (var data in startingArray)
    {
      MyLinkedListNode<T> nextNode = new MyLinkedListNode<T>(data);
      if (Head == null || previous == null)
      {
        Head = nextNode;
      }
      else
      {
        previous.Next = nextNode;
      }
      previous = nextNode;
    }
  }

  public void Add(T newData)
  {
    var current = Head;
    while (current.Next != null)
    {
      current = current.Next;
    }
    current.Next = new MyLinkedListNode<T>(newData);
  }

  public T? Pop()
  {

    if (Head == null)
      return default(T);

    if (Head.Next == null)
    {
      var value = Head.Data;
      Head = null;
      return value;
    }


    MyLinkedListNode<T> current = Head;
    // when are we going to stop
    // stop right before the last guy
    while (current.Next.Next != null)
    {
      current = current.Next;
    }

    // get a reference to the last guy's data
    var othervalue = current.Next.Data;
    // set the second to last guy's Next property to null 
    // (this removes the last guy from the list)
    current.Next = null;
    // return the data of the last guy (the one who was removed)
    return othervalue;

  }

  public IEnumerator GetEnumerator() =>
    new MyListEnumerator<T>(Head);

  IEnumerator<T> IEnumerable<T>.GetEnumerator()
  {
    return new MyListEnumerator<T>(Head);
  }
}

public class MyListEnumerator<T> : IEnumerator<T>
{
  private MyLinkedListNode<T> head { get; }
  private MyLinkedListNode<T> currentNode { get; set; }
  public object Current =>
    currentNode.Data ?? default(T);

  T IEnumerator<T>.Current => 
    currentNode.Data ?? default(T);

  public MyListEnumerator(MyLinkedListNode<T>? head)
  {
    this.head = head;
  }

  public bool MoveNext()
  {
    bool listIsEmpty = head == null;
    if (listIsEmpty)
      return false;

    bool haveNotStartedWalkingThroughList = currentNode == null;
    if (haveNotStartedWalkingThroughList)
    {
      currentNode = head;
      return true;
    }

    bool areAtTheEndOfTheList = currentNode!.Next == null;
    if (areAtTheEndOfTheList)
      return false;

    currentNode = currentNode.Next;
    return true;
  }

  public void Reset()
  {
    currentNode = null;
  }

  public void Dispose()
  {
    currentNode = null;
  }
}