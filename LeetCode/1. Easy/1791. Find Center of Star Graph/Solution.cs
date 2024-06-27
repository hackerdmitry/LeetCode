namespace LeetCode._1._Easy._1791._Find_Center_of_Star_Graph;

public class Solution
{
    public int FindCenter(int[][] edges) =>
        edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1] ? edges[0][0] : edges[0][1];
}
