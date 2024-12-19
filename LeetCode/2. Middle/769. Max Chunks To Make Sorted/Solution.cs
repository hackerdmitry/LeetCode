using System.Collections.Generic;

namespace LeetCode._2._Middle._769._Max_Chunks_To_Make_Sorted;

public class Solution
{
    public int MaxChunksToSorted(int[] arr)
    {
        var needNumChunk = new HashSet<int>();
        var chunkCount = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] > i)
                needNumChunk.Add(arr[i]);
            needNumChunk.Remove(i);

            if (needNumChunk.Count == 0)
                chunkCount++;
        }

        return chunkCount;
    }
}
