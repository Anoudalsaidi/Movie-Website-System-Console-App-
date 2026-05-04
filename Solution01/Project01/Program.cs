using System;
using System.Collections.Generic;

namespace MovieWebsiteSystem
{
    // ===================== Movie Class =====================
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }

        // Constructor
        public Movie(string title, string genre, int year, int rating = 5)
        {
            Title = title;
            Genre = genre;
            Year = year;

            // Validation
            if (rating < 1 || rating > 10)
                Rating = 5;
            else
                Rating = rating;
        }
    }

    // ===================== User Class =====================
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public User(string name, int age)
        {
            Name = name;
            Age = age;

            // Welcome Message (Bonus)
            Console.WriteLine($"Welcome {Name}!");
        }
    }

    // ===================== Review Class =====================
    class Review
    {
        public string UserName { get; set; }
        public string MovieTitle { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }

        // Constructor
        public Review(string userName, string movieTitle, string comment, int rate)
        {
            UserName = userName;
            MovieTitle = movieTitle;
            Comment = comment;
            Rate = rate;
        }
    }

    // ===================== Main Program =====================
    class Program
    {
        static void Main(string[] args)
        {
            // Create Movies
            Movie m1 = new Movie("Inception", "Sci-Fi", 2010, 9);
            Movie m2 = new Movie("Titanic", "Romance", 1997, 8);
            Movie m3 = new Movie("Interstellar", "Sci-Fi", 2014, 10);

            List<Movie> movies = new List<Movie> { m1, m2, m3 };

            // Create User
            User u1 = new User("Anoud", 25);

            // Create Review
            Review r1 = new Review("Anoud", "Inception", "Great movie!", 9);

            List<Review> reviews = new List<Review> { r1 };

            // ===================== Display Movies =====================
            Console.WriteLine("\nMovies:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title} - {movie.Rating}");
            }

            // ===================== Display Reviews =====================
            Console.WriteLine("\nReviews:");
            foreach (var review in reviews)
            {
                Console.WriteLine($"{review.UserName} rated {review.MovieTitle}: {review.Rate} - {review.Comment}");
            }
        }
    }
}