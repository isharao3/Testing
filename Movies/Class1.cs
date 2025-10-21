using Movies;
namespace MMS
{
    public class MMS
    {
        private static List<Movie> Movies = new List<Movie>() { new Movie() { Name = "Avvai Shanmukhi", Release = Convert.ToDateTime("11/2/2005"), Rating = 5, Cast = "kamalahasan" },
         new Movie() { Name = "Pushpa", Release = Convert.ToDateTime("11/4/2005"), Rating = 5, Cast = "Allu Arjun, Rashmika Mandanna" },
         new Movie() { Name = "Jumanji", Release = Convert.ToDateTime("11/4/2025"), Rating = 4, Cast = "Rock" }
        };
        public static List<Movie> GetAllMovies() { return Movies; }
        public static bool AddMovie(string movie, DateTime release, int rating, string cast)
        {
            var result = false;
            try
            {
                Movies.Add(new Movie() { Name = movie, Release = release, Rating = rating, Cast = cast });
                result = true;
            }
            catch { }
            return result;
        }
    }
}
