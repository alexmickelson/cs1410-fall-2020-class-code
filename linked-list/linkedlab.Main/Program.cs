var firstData = new DataValue(0, "one");//location 1 created
var secondData = new DataValue(0, "one"); // location 2 created
var node1 = new MyLinkedListNode(firstData);
var node2 = new MyLinkedListNode(secondData);

var originalFirstRecord = firstData; // location 1 assigned
firstData = firstData with { Message = "changed" }; // location 3 created

(int ID, string Message) = firstData;
System.Console.WriteLine(originalFirstRecord);
System.Console.WriteLine(firstData);

// var startingArray = new DataValue[] {
//   new DataValue {ID = 0, Message = "one"},
//   new DataValue {ID = 0, Message = "two"},
//   new DataValue {ID = 0, Message = "three"}
// // };

// var myList = new MyList(startingArray);
// System.Console.WriteLine(myList.Pop());
// System.Console.WriteLine(myList.Pop());
// System.Console.WriteLine(myList.Pop());