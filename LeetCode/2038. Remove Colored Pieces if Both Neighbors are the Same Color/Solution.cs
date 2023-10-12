namespace LeetCode._2038._Remove_Colored_Pieces_if_Both_Neighbors_are_the_Same_Color
{
    public class Solution
    {
        public bool WinnerOfGame(string colors)
        {
            var a = 0;
            var b = 0;
            for (var i = 2; i < colors.Length; i++)
            {
                if (colors[i] == colors[i - 1] && colors[i] == colors[i - 2])
                {
                    if (colors[i] == 'A')
                        a++;
                    else
                        b++;
                }
            }

            return a > b;
        }
    }
}