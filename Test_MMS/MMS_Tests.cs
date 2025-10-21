using Movies;
using MMS;
namespace Test_MMS
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Get_All_Movies()
        {
            //Act
            var actuals = MMS.MMS.GetAllMovies();

            //Assert
            Assert.That(actuals, Is.All.TypeOf<Movie>());
            Assert.That(actuals, Has.Count.GreaterThan(0));
        }
        [TestCase("Kantara 2", "10/02/2025",4,"",true)]
        public void Test_Add_New_Movie(string movie, string release, int rating, string cast, bool expected)
        {
            var before_totalMovies = MMS.MMS.GetAllMovies().Count;
            var actuals = MMS.MMS.AddMovie(movie, Convert.ToDateTime(release), rating, cast);
            var after_totalMovies = MMS.MMS.GetAllMovies().Count;

            //Assert
            Assert.That(actuals, Is.EqualTo(expected));
            Assert.That(after_totalMovies, Is.EqualTo(before_totalMovies + 1));

            
        }

    }
}