using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating="PG",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "G",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    },

                    new Movie
                    {
                        Title = "Red Cliff",
                        ReleaseDate = DateTime.Parse("2008-3-2"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 5.00M
                    },

                    new Movie
                    {
                        Title = "Hero",
                        ReleaseDate = DateTime.Parse("2002-2-26"),
                        Genre = "Action",
                        Rating = "G",
                        Price = 8.00M
                    },

                    new Movie
                    {
                        Title = "Kung Fu Hustle",
                        ReleaseDate = DateTime.Parse("2004-10-29"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 7.00M
                    },

                    new Movie
                    {
                        Title = "Ip Man 3",
                        ReleaseDate = DateTime.Parse("2015-3-29"),
                        Genre = "Fighting",
                        Rating = "PG",
                        Price = 5.50M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}