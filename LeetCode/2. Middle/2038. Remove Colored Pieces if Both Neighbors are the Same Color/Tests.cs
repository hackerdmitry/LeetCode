using NUnit.Framework;

namespace LeetCode._2._Middle._2038._Remove_Colored_Pieces_if_Both_Neighbors_are_the_Same_Color
{
    [TestFixture(TestName = "2038. Remove Colored Pieces if Both Neighbors are the Same Color")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase("AAABABB", true)]
        [TestCase("AA", false)]
        [TestCase("AAABABBB", false)]
        [TestCase("ABBB", false)]
        [TestCase("ABBBBBBBAAA", false)]
        public void Test(string input, bool output)
        {
            var solution = new Solution();
            var actual = solution.WinnerOfGame(input);
            Assert.AreEqual(output, actual);
        }
    }
}