using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1267._Count_Servers_that_Communicate;

public class Solution
{
    public int CountServers(int[][] grid)
    {
        var height = grid.Length;
        var width = grid[0].Length;

        var yNetworks = new int[height];
        var xNetworks = new int[width];
        var networks = new List<int>();

        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
                if (grid[y][x] == 1)
                    switch (yNetworks[y] != 0, xNetworks[x] != 0)
                    {
                        case (true, true):
                            if (yNetworks[y] != xNetworks[x])
                            {
                                networks[xNetworks[x] - 1] += networks[yNetworks[y] - 1];
                                networks[yNetworks[y] - 1] = 0;
                            }
                            xNetworks[x] = yNetworks[y];
                            networks[yNetworks[y] - 1]++;
                            break;
                        case (true, false):
                            xNetworks[x] = yNetworks[y];
                            networks[yNetworks[y] - 1]++;
                            break;
                        case (false, true):
                            yNetworks[y] = xNetworks[x];
                            networks[yNetworks[y] - 1]++;
                            break;
                        case (false, false):
                            networks.Add(1);
                            yNetworks[y] = xNetworks[x] = networks.Count;
                            break;
                    }

        return networks.Where(x => x > 1).Sum();
    }
}