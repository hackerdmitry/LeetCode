using System;
using System.Collections;
using NUnit.Framework;

namespace LeetCode._706._Design_HashMap
{
    [TestFixture(TestName = "706. Design HashMap")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCaseSource(nameof(Input))]
        public void Test(ValueTuple<string, object>[] input, int?[] output)
        {
            MyHashMap myHashMap = null;
            var actual = new int?[output.Length];
            var actualIndex = 0;
            foreach (var (action, parameters) in input)
            {
                switch (action)
                {
                    case "MyHashMap":
                        myHashMap = new MyHashMap();
                        actualIndex++;
                        break;
                    case "put":
                        var values = (ValueTuple<int, int>) parameters;
                        myHashMap.Put(values.Item1, values.Item2);
                        actualIndex++;
                        break;
                    case "get":
                        actual[actualIndex++] = myHashMap.Get((int) parameters);
                        break;
                    case "remove":
                        myHashMap.Remove((int) parameters);
                        actualIndex++;
                        break;
                }
            }

            Assert.AreEqual(output, actual);
        }

        private static IEnumerable Input()
        {
            var input = new ValueTuple<string, object>[]
            {
                ("MyHashMap", null),
                ("put", (1, 1)),
                ("put", (2, 2)),
                ("get", 1),
                ("get", 3),
                ("put", (2, 1)),
                ("get", 2),
                ("remove", 2),
                ("get", 2),
            };
            var output = new int?[] { null, null, null, 1, -1, null, 1, null, -1 };
            yield return new object[] { input, output };
        }
    }
}