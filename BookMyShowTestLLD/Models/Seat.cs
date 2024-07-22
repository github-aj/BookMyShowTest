namespace BookMyShowTestLLD.Models
{
    internal class Seat
    {
        int seatId;
        int row;
        int column;

        SeatType typeOfSeat;
        SeatStatus statusOfSeat;
        List<Show> seats;
    }
}