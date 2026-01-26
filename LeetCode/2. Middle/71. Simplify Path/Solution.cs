using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._71._Simplify_Path;

public class Solution
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();
        foreach (var folder in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            switch (folder)
            {
                case ".":
                    continue;
                case "..":
                    if (stack.Count > 0)
                        stack.Pop();
                    break;
                default:
                    stack.Push(folder);
                    break;
            }
        }

        return "/" + string.Join("/", stack.Reverse());
    }
}
