using System.Collections;
using NUnit.Framework;

namespace LeetCode._2._Middle._1845._Seat_Reservation_Manager;

[TestFixture(TestName = "1845. Seat Reservation Manager")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(string[] input1, int?[] input2, int?[] output)
    {
        var actual = new int?[input2.Length];

        SeatManager seatManager = null;

        for (var i = 0; i < input1.Length; i++)
        {
            var method = input1[i];
            var arg = input2[i];

            switch (method)
            {
                case "SeatManager":
                    seatManager = new SeatManager(arg!.Value);
                    break;
                case "reserve":
                    actual[i] = seatManager.Reserve();
                    break;
                case "unreserve":
                    seatManager.Unreserve(arg!.Value);
                    break;
            }
        }

        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new[]{"SeatManager", "reserve", "reserve", "unreserve", "reserve", "reserve", "reserve", "reserve", "unreserve"},
            new int?[]{5,null,null,2,null,null,null,null,5},
            new int?[]{null, 1, 2, null, 2, 3, 4, 5, null},
        };
        yield return new object[]
        {
            new[]{"SeatManager","reserve","unreserve","reserve","unreserve","reserve","unreserve","reserve","reserve","reserve","reserve","reserve","unreserve","unreserve","unreserve","reserve","unreserve","reserve","reserve","unreserve","unreserve","reserve","unreserve","unreserve","unreserve","reserve","unreserve","reserve","reserve","reserve","reserve","unreserve","reserve","reserve","reserve","unreserve","unreserve","unreserve","reserve","unreserve","reserve","reserve","reserve","unreserve","reserve","unreserve","unreserve","unreserve","unreserve","reserve","unreserve","unreserve","reserve","unreserve","unreserve","reserve","reserve","reserve","reserve","unreserve","reserve"},
            new int?[]{798,null,1,null,1,null,1,null,null,null,null,null,5,3,2,null,4,null,null,1,3,null,2,4,1,null,1,null,null,null,null,1,null,null,null,1,3,2,null,5,null,null,null,5,null,6,4,5,1,null,2,3,null,1,2,null,null,null,null,2,null},
            new int?[]{null,1,null,1,null,1,null,1,2,3,4,5,null,null,null,2,null,3,4,null,null,1,null,null,null,1,null,1,2,3,4,null,1,5,6,null,null,null,1,null,2,3,5,null,5,null,null,null,null,1,null,null,2,null,null,1,2,3,4,null,2},
        };
    }
}
