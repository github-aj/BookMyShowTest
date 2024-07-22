namespace BookMyShowTestLLD.Models
{
    public class Show
    {
        int showId;
        DateTime startDateTime;
        DateTime endDateTime;
        Movie movie;

        CinemaHall cinemaHallPlayedAt;
    }
}