namespace linkedlab.Test;

public class MyListTest
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void TestThatPopWorks()
  {
    var testList = new MyList<DataValue>(
      new DataValue[]
      {
        new DataValue(1, "one"),
        new DataValue(2, "two"),
        new DataValue(3, "three"),
      }
    );

    var poppedData = testList.Pop();

    Assert.AreEqual("three", poppedData?.Message);
    Assert.AreEqual(3, poppedData?.ID);
  }

  [Test]
  public void TestCountWorks()
  {

    var testList = new MyList<DataValue>(
      new DataValue[]
      {
        new DataValue(1, "one"),
        new DataValue(2, "two"),
        new DataValue(3, "three"),
      }
    );
    Assert.AreEqual(3, testList.Count);

    testList.Pop();
    Assert.AreEqual(2, testList.Count);
  }

  [Test]
  public void TestAdd()
  {
    var testList = new MyList<DataValue>(
      new DataValue[]
      {
        new DataValue(1, "one"),
        new DataValue(2, "two"),
        new DataValue(3, "three"),
      }
    );

    testList.Add(new DataValue(4, "four"));

    Assert.AreEqual("four", testList.Pop().Message);
  }

  [Test]
  public void IEnumerableTest()
  {
    var testList = new MyList<DataValue>(
      new DataValue[]
      {
        new DataValue(1, "one"),
        new DataValue(2, "two"),
        new DataValue(3, "three"),
      }
    );
    var expectedArray = new DataValue[]
      {
        new DataValue(1, "one"),
        new DataValue(2, "two"),
        new DataValue(3, "three"),
      };
    CollectionAssert.AreEqual(testList, expectedArray);
  }
}