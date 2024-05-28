namespace LeetCode._3._Hard._552._Student_Attendance_Record_II;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int CheckRecord(int n)
    {
        var (a, al1, al2, ap, l1, l2, p) = (1L, 0L, 0L, 0L, 1L, 0L, 1L);

        for (var i = 1; i < n; i++)
        {
            var na = l1 + l2 + p;
            var nal1 = a + ap;
            var nal2 = al1;
            var nap = a + al1 + al2 + ap;
            var nl1 = p;
            var nl2 = l1;
            var np = l1 + l2 + p;

            a = na % modulo;
            al1 = nal1 % modulo;
            al2 = nal2 % modulo;
            ap = nap % modulo;
            l1 = nl1 % modulo;
            l2 = nl2 % modulo;
            p = np % modulo;
        }

        return (int) ((a + al1 + al2 + ap + l1 + l2 + p) % modulo);
    }
}