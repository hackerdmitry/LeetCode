using System;
using System.Collections;
using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._2642._Design_Graph_With_Shortest_Path_Calculator;

[TestFixture(TestName = "2642. Design Graph With Shortest Path Calculator")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(string[] input1, List<string> input2, int?[] output)
    {
        Graph graph = null;

        for (var i = 0; i < input1.Length; i++)
        {
            var command = input1[i].Trim('"');
            switch (command)
            {
                case "Graph":
                {
                    var startPosSecondArg = input2[i].IndexOf('[', 1);
                    var args = input2[i].Substring(startPosSecondArg, input2[i].Length - 1 - startPosSecondArg).ParseIntArray2d();
                    graph = new Graph(args.Length, args);
//                    Assert.AreEqual(output[i], null);
                    break;
                }
                case "shortestPath":
                {
                    var args = input2[i].ParseIntArray();
                    var length = graph.ShortestPath(args[0], args[1]);
//                    Assert.AreEqual(output[i], length);
                    break;
                }
                case "addEdge":
                {
                    var args = input2[i].ParseIntArray();
                    graph.AddEdge(args);
//                    Assert.AreEqual(output[i], null);
                    break;
                }
            }
        }

        //        var graph = new Graph(4, new[]
//        {
//            new[] { 0, 2, 5 },
//            new[] { 0, 1, 2 },
//            new[] { 1, 2, 1 },
//            new[] { 3, 0, 3 },
//        });
//        var sp1 = graph.ShortestPath(3, 2);
//        Assert.AreEqual(6, sp1);
//        var sp2 = graph.ShortestPath(0, 3);
//        Assert.AreEqual(-1, sp2);
//
//        graph.AddEdge(new[] { 1, 3, 4 });
//
//        var sp3 = graph.ShortestPath(0, 3);
//        Assert.AreEqual(6, sp3);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[""Graph"", ""shortestPath"", ""shortestPath"", ""addEdge"", ""shortestPath""]
[[4, [[0, 2, 5], [0, 1, 2], [1, 2, 1], [3, 0, 3]]], [3, 2], [0, 3], [[1, 3, 4]], [0, 3]]
[null, 6, -1, null, 6]

[""Graph"",""addEdge"",""addEdge"",""addEdge"",""addEdge"",""addEdge"",""shortestPath"",""shortestPath"",""shortestPath"",""addEdge"",""addEdge"",""addEdge"",""shortestPath"",""addEdge"",""addEdge"",""shortestPath"",""shortestPath"",""shortestPath"",""addEdge"",""addEdge"",""shortestPath"",""shortestPath"",""shortestPath"",""shortestPath"",""addEdge"",""addEdge"",""shortestPath"",""shortestPath"",""shortestPath"",""shortestPath"",""shortestPath"",""addEdge"",""shortestPath"",""addEdge"",""shortestPath"",""shortestPath"",""shortestPath"",""addEdge"",""shortestPath"",""shortestPath"",""shortestPath"",""shortestPath"",""shortestPath"",""addEdge"",""shortestPath"",""shortestPath"",""shortestPath""]
[[13,[[11,6,84715],[7,9,764823],[6,0,315591],[1,4,909432],[6,5,514907],[9,6,105610],[3,10,471042],[7,10,348752],[5,11,715628],[6,1,973999],[8,7,593929],[7,6,64688],[6,4,741734],[10,1,894247],[9,7,81181],[2,11,75418],[12,2,85431],[7,2,260306],[11,9,640614],[2,3,648804],[4,12,568023],[0,8,730096],[9,11,633474],[3,6,390214],[1,10,117955],[9,8,222602],[10,7,689294]]],[[1,2,36450]],[[8,0,709628]],[[2,4,30185]],[[12,1,21696]],[[1,8,2553]],[8,9],[1,11],[3,4],[[4,6,2182]],[[7,5,206]],[[5,7,140]],[12,5],[[12,6,365184]],[[3,2,5]],[4,8],[7,10],[0,5],[[0,11,5]],[[1,7,5]],[0,8],[11,11],[7,4],[0,12],[[3,9,858944]],[[0,9,4]],[3,5],[4,5],[12,9],[9,8],[3,5],[[12,9,629052]],[3,8],[[4,0,545201]],[11,8],[4,11],[9,6],[[12,7,4]],[7,10],[2,5],[6,11],[12,2],[9,7],[[4,3,879736]],[1,3],[1,0],[4,6]]
[null,null,null,null,null,null,1358752,111868,1131948,null,null,null,605420,null,null,592272,348752,1324231,null,null,730096,0,290491,1394477,null,null,429354,399164,401984,222602,429354,null,570569,null,622912,317778,105610,null,348752,429349,315596,58146,81181,null,685254,380284,2182]
".Trim();

        var testCases = testCasesString.Split(
            Environment.NewLine + Environment.NewLine,
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var testCase in testCases)
        {
            var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var commands = lines[0].ParseStringArray();

            var arguments = lines[1].Replace(" ", "");

            var args = new List<string>();
            var argsStack = new Stack<int>();
            for (var i = 0; i < arguments.Length; i++)
            {
                switch (arguments[i])
                {
                    case '[':
                        argsStack.Push(i);
                        break;
                    case ']':
                        var startPos = argsStack.Pop();
                        if (argsStack.Count == 1)
                        {
                            var line = arguments.Substring(startPos, i - startPos + 1);
                            args.Add(line);
                        }
                        break;
                }
            }

            var output = lines[2].ParseNullIntArray();
            yield return new object[] { commands, args, output };
        }
    }
}
