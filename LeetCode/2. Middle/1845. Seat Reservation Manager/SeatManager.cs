namespace LeetCode._2._Middle._1845._Seat_Reservation_Manager;

public class SeatManager
{
    private bool[] seats;
    private int minFreeSeat;

    public SeatManager(int n)
    {
        seats = new bool[n];
        minFreeSeat = 0;
    }

    public int Reserve()
    {
        for (var i = minFreeSeat; i < seats.Length; i++)
        {
            if (!seats[i])
            {
                minFreeSeat = i + 1;
                seats[i] = true;
                return minFreeSeat;
            }
        }

        return -1;
    }

    public void Unreserve(int seatNumber)
    {
        seatNumber--;

        seats[seatNumber] = false;
        if (seatNumber < minFreeSeat)
            minFreeSeat = seatNumber;
    }
}