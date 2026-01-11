using System.Collections.Generic;

namespace LeetCode._2._Middle._649._Dota2_Senate;

public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        var radiantQueue = new Queue<int>();
        var direQueue = new Queue<int>();

        for (var i = 0; i < senate.Length; i++)
            if (senate[i] == 'R')
                radiantQueue.Enqueue(i);
            else
                direQueue.Enqueue(i);

        while (radiantQueue.Count > 0 && direQueue.Count > 0)
        {
            var radiant = radiantQueue.Dequeue();
            var dire = direQueue.Dequeue();
            if (radiant < dire)
                radiantQueue.Enqueue(radiant + senate.Length);
            else
                direQueue.Enqueue(dire + senate.Length);
        }

        return radiantQueue.Count > 0 ? "Radiant" : "Dire";
    }
}