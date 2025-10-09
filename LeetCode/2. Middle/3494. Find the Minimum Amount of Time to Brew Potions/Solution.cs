using System.Linq;

namespace LeetCode._2._Middle._3494._Find_the_Minimum_Amount_of_Time_to_Brew_Potions;

public class Solution
{
    public long MinTime(int[] skill, int[] mana)
    {
        var prevTimeWizards = new long[skill.Length + 1];
        for (var i = 1; i <= skill.Length; i++)
            prevTimeWizards[i] = skill[i - 1] * mana[0] + prevTimeWizards[i - 1];

        var timeWizards = new long[skill.Length + 1];
        foreach (var difficulty in mana.Skip(1))
        {
            timeWizards[0] = prevTimeWizards[1];
            for (var i = 1; i <= skill.Length; i++)
            {
                var prevEndTime = prevTimeWizards[i];
                var startTime = timeWizards[i - 1];
                var endTime = startTime + skill[i - 1] * difficulty;
                if (startTime < prevEndTime)
                {
                    var addTime = prevEndTime - startTime;
                    timeWizards[0] += addTime;
                    timeWizards[i] = endTime + addTime;
                }
                else
                    timeWizards[i] = endTime;
            }

            for (var i = 1; i <= skill.Length; i++)
                timeWizards[i] = timeWizards[i - 1] + skill[i - 1] * difficulty;

            (prevTimeWizards, timeWizards) = (timeWizards, prevTimeWizards);
        }

        return prevTimeWizards[^1];
    }
}