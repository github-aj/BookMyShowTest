using System;
namespace BookMyShowTestLLD.Models
{
	public class CinemaHall
	{
		int cinemaHallId;
		string cinemaHallName;
		Address address;
		List<Audi> audiList;
		public CinemaHall()
		{
		}

		public Dictionary<DateTime, Movie> getMovies(List<DateOnly> dateList)
		{
			throw null; 
		}

		public Dictionary<DateTime, Show> getShow(List<DateOnly> dateList)
		{
			return null;
		}

		
	}
}

