// See https://aka.ms/new-console-template for more information

Func<int, bool> isEven = (int i) => (i % 2) == 0;
Action<int> doesNothing = (int i) => { };
//Action - no return value
//Func - has a return

var mySieve = new Sieve(isEven);


var myList = new List<string>() { "1", "2", "3" };

Func<string, int> convertStringToInt = (string i) => int.Parse(i);



// var myListAsInt = myList
//   .TransformEachItemInList(convertStringToInt)
//   .TransformEachItemInList(ouputAndReturnFunction);


var intList = new List<int>() { 3, 5, 7 };

var MyMassiveFunction = (int i) =>
{
  System.Console.WriteLine(i);
  var transformed = i == 5;
  System.Console.WriteLine(transformed);
  return transformed;
};
intList.TransformEachItemInList(MyMassiveFunction);

// intList
//   .TransformEachItemInList(ouputAndReturnFunction)
//   .TransformEachItemInList((int i) => i == 5)
//   .TransformEachItemInList(ouputAndReturnFunction);




T ouputAndReturnFunction<T>(T i)
{
  System.Console.WriteLine(i);
  return i;
}