using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace LeetCode._2251._Number_of_Flowers_in_Full_Bloom
{
    [TestFixture(TestName = "2251. Number of Flowers in Full Bloom")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCaseSource(nameof(Input))]
        public void Test(int[][] input1, int[] input2, int[] output)
        {
            var solution = new Solution();
            var actual = solution.FullBloomFlowers(input1, input2);

            Console.WriteLine("Expected: " + string.Join(", ", output)); // TODO
            Console.WriteLine("Actual: " + string.Join(", ", actual)); // TODO

            Assert.AreEqual(output, actual);
        }

        private static IEnumerable Input()
        {
            var testCasesString = @"
[[1,6],[3,7],[9,12],[4,13]]
[2,3,7,11]
[1,2,2,2]

[[1,10],[3,3]]
[3,3,2]
[2,2,1]

[[1,10]]
[11]
[0]

[[1,2],[4,6]]
[3]
[0]

[[1,2],[4,6]]
[5]
[1]

[[43,50],[31,39],[37,42],[38,47],[22,25],[31,42],[29,43],[15,30],[37,42]]
[47,4,12,12,30,18,17]
[2,0,0,0,2,1,1]

[[32,36],[20,26],[32,32],[43,46],[40,50],[9,10],[19,19],[2,23],[36,37],[38,48],[13,25],[12,48],[21,33],[4,43],[43,49],[35,46],[41,44],[36,44],[40,50],[42,47],[27,50],[7,43],[5,41],[32,35],[24,31],[33,42],[44,47],[32,46],[39,46],[48,50],[10,49],[14,19],[13,20],[41,43],[39,48],[33,44],[23,37],[34,48],[36,36],[6,12],[14,17],[31,34],[28,40],[11,31],[17,50],[31,47],[17,21],[33,49],[20,29],[27,43],[18,47],[46,47],[29,49],[50,50],[5,24],[19,27],[16,24],[18,42],[5,17],[17,26]]
[19,17,42,36,43,42,25,35,31,21,49,14,1,4,24,12,38,48,33,36,37,8,45,50,27,20,45,42,12,5,32,41,16,23,30,29,1,37,16,42,43,5,50,6,49,22,34,24,6]
[19,17,26,24,26,26,17,22,18,19,9,13,0,2,19,10,21,13,22,24,22,7,20,6,16,19,20,26,10,5,20,26,14,19,16,17,0,22,14,26,26,5,6,6,9,18,22,19,6]
".Trim();

            var testCases = testCasesString.Split(
                Environment.NewLine + Environment.NewLine,
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var testCase in testCases)
            {
                var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                var input1 = ParseIntArray2d(lines[0]);
                var input2 = ParseIntArray(lines[1]);
                var output = ParseIntArray(lines[2]);
                yield return new object[] { input1, input2, output };
            }
        }

        private static int[][] ParseIntArray2d(string line)
        {
            var matches = Regex.Matches(line, @"(?<=\[)((\-?\d+,?)+)(?=\])");
            return matches
                .Select(x => x
                    .Value
                    .Split(',')
                    .Select(y => int.Parse(y.Trim()))
                    .ToArray())
                .ToArray();
        }

        private static int[] ParseIntArray(string line)
        {
            var array = line.TrimStart('[').TrimEnd(']');
            return array
                .Split(',')
                .Select(x => int.Parse(x.Trim()))
                .ToArray();
        }
    }
}