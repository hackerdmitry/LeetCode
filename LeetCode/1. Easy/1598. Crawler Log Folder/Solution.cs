namespace LeetCode._1._Easy._1598._Crawler_Log_Folder;

public class Solution
{
    public int MinOperations(string[] logs)
    {
        var depth = 0;
        foreach (var log in logs)
        {
            switch (log)
            {
                case "../":
                    depth--;
                    if (depth < 0)
                        depth = 0;
                    break;
                case "./":
                    break;
                default:
                    depth++;
                    break;
            }
        }

        return depth;
    }
}
