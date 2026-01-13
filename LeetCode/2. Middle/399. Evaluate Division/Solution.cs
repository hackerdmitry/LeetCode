using System.Collections.Generic;

namespace LeetCode._2._Middle._399._Evaluate_Division;

public class Solution
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var nodes = new Dictionary<string, LinkedList<(string, double)>>();
        for (var i = 0; i < equations.Count; i++)
        {
            var u = equations[i][0];
            var v = equations[i][1];
            var value = values[i];

            if (!nodes.ContainsKey(u))
                nodes[u] = new LinkedList<(string, double)>();
            if (!nodes.ContainsKey(v))
                nodes[v] = new LinkedList<(string, double)>();

            nodes[u].AddLast((v, value));
            nodes[v].AddLast((u, 1d / value));
        }

        var visited = new HashSet<string>();
        var result = new double[queries.Count];
        for (var i = 0; i < queries.Count; i++)
        {
            var query = queries[i];
            var localResult = Dfs(query[0], query[1], 1d);
            result[i] = localResult == double.MinValue ? -1d : localResult;
            visited.Clear();
        }

        return result;

        double Dfs(string start, string end, double acc)
        {
            if (nodes.TryGetValue(start, out var neighbours))
            {
                if (start == end)
                    return acc;

                visited.Add(start);

                foreach (var (next, value) in neighbours)
                {
                    if (visited.Contains(next))
                        continue;

                    var dfs = Dfs(next, end, acc * value);
                    if (dfs != double.MinValue)
                        return dfs;
                }
            }

            return double.MinValue;
        }
    }
}
