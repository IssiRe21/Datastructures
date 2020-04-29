using System;
using System.Collections.Generic;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> movieNames = new List<string>();
            movieNames.Add("Pulp Fiction");
            movieNames.Add("Harry Potter");
            movieNames.Add("Pacific Rim");

            Console.WriteLine(movieNames[1]);

            //HashSet no permite elementos repetidos
            HashSet<string> movieNames2 = new HashSet<string>();
            movieNames2.Add("Bad Boys");
            movieNames2.Add("Bad Boys");
            movieNames2.Add("The Avengers");
            movieNames2.Add("The Avengers");
            Console.WriteLine(movieNames2.Count);

            HashSet<Movie> moviesSet = new HashSet<Movie>();
            moviesSet.Add(new Movie("Bad Boys", 1983));
            moviesSet.Add(new Movie("Bad Boys", 1995));
            moviesSet.Add(new Movie("Bad Boys", 1995));
            Console.WriteLine(movieNames2.Count);

            Dictionary<string, string> favoriteColors = new Dictionary<string, string>();
            favoriteColors.Add("Johnny", "Blue");
            favoriteColors.Add("Jack", "Black");
            favoriteColors.Add("Ruperto", "Grey");

            //What is Jack's favorite color?
            string jackFavoriteColor = favoriteColors.GetValueOrDefault("Jack");
            Console.WriteLine($"jackFavoriteColor = {jackFavoriteColor}");

            int[] numbers = new int[3] { 1, 2, 3 };


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (var key in favoriteColors.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in favoriteColors.Values)
            {
                Console.WriteLine(value);
            }
        }

    }
}
