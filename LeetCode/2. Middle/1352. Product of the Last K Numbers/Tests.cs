using NUnit.Framework;

namespace LeetCode._2._Middle._1352._Product_of_the_Last_K_Numbers;

[TestFixture(TestName = "1352. Product of the Last K Numbers")]
public class Tests
{
    [Timeout(1000)]
    public void Test1()
    {
        var productOfNumbers = new ProductOfNumbers();
        productOfNumbers.Add(3);
        productOfNumbers.Add(0);
        productOfNumbers.Add(2);
        productOfNumbers.Add(5);
        productOfNumbers.Add(4);
        Assert.AreEqual(20, productOfNumbers.GetProduct(2));
        Assert.AreEqual(40, productOfNumbers.GetProduct(3));
        Assert.AreEqual(0, productOfNumbers.GetProduct(4));
        productOfNumbers.Add(8);
        Assert.AreEqual(32, productOfNumbers.GetProduct(2));
    }
}