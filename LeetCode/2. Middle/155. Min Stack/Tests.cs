using NUnit.Framework;

namespace LeetCode._2._Middle._155._Min_Stack;

[TestFixture(TestName = "155. Min Stack")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test()
    {
        var minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        Assert.AreEqual(-3, minStack.GetMin());
        minStack.Pop();
        Assert.AreEqual(0, minStack.Top());
        Assert.AreEqual(-2, minStack.GetMin());
    }
}
