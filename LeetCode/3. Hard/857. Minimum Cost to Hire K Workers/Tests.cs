using NUnit.Framework;

namespace LeetCode._3._Hard._857._Minimum_Cost_to_Hire_K_Workers;

[TestFixture(TestName = "857. Minimum Cost to Hire K Workers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[] {10, 20, 5}, new[] {70, 50, 30}, 2, 105.00000)]
    [TestCase(new[] {3, 1, 10, 10, 1}, new[] {4, 8, 2, 2, 7}, 3, 30.66667)]
    [TestCase(new[] {5, 5, 5, 1}, new[] {14, 5, 7, 5}, 3, 42.00000)]
    [TestCase(new[] {2, 1, 5}, new[] {17, 6, 4}, 2, 25.50000)]
    [TestCase(new[] {2}, new[] {14}, 1, 14.00000)]
    [TestCase(new[] {14, 56, 59, 89, 39, 26, 86, 76, 3, 36}, new[] {90, 217, 301, 202, 294, 445, 473, 245, 415, 487}, 2, 399.53846)]
    [TestCase(new[] {32, 43, 66, 9, 94, 57, 25, 44, 99, 19}, new[] {187, 366, 117, 363, 121, 494, 348, 382, 385, 262}, 4, 1528.00000)]
    public void Test(int[] input1, int[] input2, int input3, double output)
    {
        var solution = new Solution();
        var actual = solution.MincostToHireWorkers(input1, input2, input3);
        Assert.AreEqual(output, actual, 1e-5);
    }
}