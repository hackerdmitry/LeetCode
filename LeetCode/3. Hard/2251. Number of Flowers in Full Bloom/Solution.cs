using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._2251._Number_of_Flowers_in_Full_Bloom
{
    public class Solution
    {
        public int[] FullBloomFlowers(int[][] flowers, int[] people)
        {
            var queue = new PriorityQueue<int[], int>();

            Array.Sort(flowers, (f1, f2) => f1[0].CompareTo(f2[0]));
            var counts = new List<(int, int, int)>();

            int[] lastFlower = null;
            foreach (var flower in flowers)
            {
                if (queue.Count != 0)
                {
                    while (queue.Count > 0)
                    {
                        var peek = queue.Peek();
                        if (flower[0] <= peek[1])
                        {
                            var start = lastFlower[0];
                            if (flower[0] - 1 >= start)
                                counts.Add((start, flower[0] - 1, queue.Count));
                            queue.Enqueue(flower, flower[1]);
                            break;
                        }

                        if (peek[1] >= lastFlower[0])
                            counts.Add((lastFlower[0], peek[1], queue.Count));
                        lastFlower[0] = queue.Dequeue()[1] + 1;
                    }
                }

                lastFlower = flower;
                if (queue.Count == 0)
                    queue.Enqueue(flower, flower[1]);
            }

            while (queue.Count > 0)
            {
                var peek = queue.Peek();
                if (peek[1] >= lastFlower[0])
                    counts.Add((lastFlower[0], peek[1], queue.Count));
                lastFlower[0] = queue.Dequeue()[1] + 1;
            }

//             DEBUG
//            for (var i = 0; i < counts.Count; i++)
//                Console.WriteLine($"{counts[i].Item3}: [{counts[i].Item1},{counts[i].Item2}]"); // TODO

            for (var i = 0; i < people.Length; i++)
            {
                people[i] = SearchInCounts(counts, people[i]);
            }

            return people;
        }

        private int SearchInCounts(List<(int, int, int)> counts, int man)
        {
            var left = 0;
            var right = counts.Count - 1;

            while (left < right)
            {
                var middle = (left + right) / 2;
                var cur = counts[middle];

                if (cur.Item1 <= man && man <= cur.Item2)
                    return cur.Item3;

                if (man < cur.Item2)
                    right = middle;
                else if (left == middle)
                    left++;
                else
                    left = middle;
            }

            if (counts[right].Item1 <= man && man <= counts[right].Item2)
                return counts[right].Item3;

            return 0;
        }
    }
}