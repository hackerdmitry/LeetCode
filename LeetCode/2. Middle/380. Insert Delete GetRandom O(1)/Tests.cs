using NUnit.Framework;

namespace LeetCode._2._Middle._380._Insert_Delete_GetRandom_O_1_;

[TestFixture(TestName = "380. Insert Delete GetRandom O(1)")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test()
    {
        var functions = new[]
        {
            "insert", "insert", "insert", "insert", "getRandom", "getRandom", "getRandom", "getRandom", "getRandom",
            "getRandom", "getRandom", "getRandom", "getRandom", "getRandom", "getRandom"
        };
        var args = new dynamic[] {1, 10, 20, 30, null, null, null, null, null, null, null, null, null, null};
        var expected = new dynamic[] {true, true, true, true, 10, 30, 20, 30, 10, 20, 30, 1, 1, 1};

        var randomizedSet = new RandomizedSet();

        for (var i = 0; i < expected.Length; i++)
        {
            switch (functions[i])
            {
                case "insert":
                    Assert.AreEqual(expected[i], randomizedSet.Insert(args[i]));
                    break;
                case "remove":
                    Assert.AreEqual(expected[i], randomizedSet.Remove(args[i]));
                    break;
                case "getRandom":
                    IsRandom(randomizedSet, expected[i], i);
                    break;
            }
        }
    }

    private void IsRandom(RandomizedSet randomizedSet, int expected, int index)
    {
        for (int i = 0; i < 1000; i++)
            if (randomizedSet.GetRandom() == expected)
                return;

        Assert.Fail($"expected {expected} in position {index}");
    }
}