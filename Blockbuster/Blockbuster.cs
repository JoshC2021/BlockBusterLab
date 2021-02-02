using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class Blockbuster
    {
            
        public static List<string> dvd1 = new List<string>()
        {
            "First Scene",
            "Second Scene",
            "Third Scene",
            "Fourth Scene",
            "Fifth Scene"
        };
        public static List<string> dvd2 = new List<string>()
        {
            "First Scene",
            "Second Scene",
            "Third Scene",
            "Fourth Scene",
            "Fifth Scene"
        };
        public static List<string> dvd3 = new List<string>()
        {
            "First Scene",
            "Second Scene",
            "Third Scene",
            "Fourth Scene",
            "Fifth Scene"
        };
        public static List<string> vhs1 = new List<string>()
        {
            "First Scene",
            "Second Scene",
            "Third Scene",
            "Fourth Scene",
            "Fifth Scene"
        };
        public static List<string> vhs2 = new List<string>()
        {
            "First Scene",
            "Second Scene",
            "Third Scene",
            "Fourth Scene",
            "Fifth Scene"
        };
        public static List<string> vhs3 = new List<string>()
        {
            "First Scene",
            "Second Scene",
            "Third Scene",
            "Fourth Scene",
            "Fifth Scene"
        };

        public  static List<Movie> Movies = new List<Movie>()
        {
            new DVD("The Shawshank Redemption",Genre.Drama,97,dvd1),
            new DVD("Jonh Wick",Genre.Action,97,dvd2),
            new DVD("Deadpool",Genre.Action,97,dvd3),
            new VHS("Titanic",Genre.Romance,97,vhs1),
            new VHS("Get Out",Genre.Horror,97,vhs2),
            new VHS("Wedding Crashers",Genre.Comedy,97,vhs3)
        };
        public void PrintMovies()
        {
            Console.WriteLine("Here are all the movies available: ");
            for(int i = 1; i <= Movies.Count;i++)
            {
                Console.WriteLine($"Movie #{i}: {Movies[i-1].Title}");
            }
        }

        public Movie CheckOut()
        {
            PrintMovies();
            while (true)
            {
                Console.WriteLine("Which movie do you want to check out(1-{0})?",Movies.Count);
                try
                {
                    int selectedMovie = int.Parse(Console.ReadLine());
                    Movies[selectedMovie - 1].PrintInfo();
                    return Movies[selectedMovie-1];
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid index, please try again");
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Need an index between the range, please try again");
                    continue;
                }
            }
        }
    }
}
