using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1431._Kids_With_the_Greatest_Number_of_Candies;

[TestFixture(TestName = "1431. Kids With the Greatest Number of Candies")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,5,1,3]", 3, "[true,true,true,false,true]")]
    [TestCase("[4,2,1,1,2]", 1, "[true,false,false,false,false]")]
    [TestCase("[12,1,12]", 10, "[true,false,true]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.KidsWithCandies(input1.ParseIntArray(), input2);
        Assert.AreEqual(output.ParseBoolArray(), actual);
    }
}
