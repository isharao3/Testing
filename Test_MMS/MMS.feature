REFERENCE DEMO GHERKIN

 

CASE: Get all the movies released in past 10years
GIVEN: A collection of movies in db
WHEN: MMS.GetAllMovies() is called
THEN: Verify that
i. The output is a List of Movie Type
ii. The count of movies > 0
 

 

CASE: Add a new movie to the database
GIVEN: Movie details: Name="Kantara 2", ReleaseDate: "02-10-2025", Rating: 5, Cast: ""
WHEN: MMS.AddMovie() is called passing the above inputs
THEN: Verify that the movie is added
      Verify that the total count of movie list has increased by 1