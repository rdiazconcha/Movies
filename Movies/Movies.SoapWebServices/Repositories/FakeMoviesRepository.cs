using System;
using System.Collections.Generic;
using System.Linq;
using Movies.SoapWebServices.Interfaces;
using Movies.SoapWebServices.Models;

namespace Movies.SoapWebServices.Repositories
{
    public class FakeMoviesRepository : IMoviesRepository
    {
        private List<Movie> movies = new List<Movie>();
        private List<Person> people = new List<Person>();
        private List<Country> countries = new List<Country>();
        private List<Role> roles = new List<Role>();

        private static FakeMoviesRepository current;
        public static FakeMoviesRepository Current
        {
            get
            {
                if (current == null)
                {
                    current = new FakeMoviesRepository();
                }

                return current;
            }
        }

        private FakeMoviesRepository()
        {
            PreloadPeople();
            PreloadCountries();
            PreloadRoles();
            PreloadMovies();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return movies.AsEnumerable();
        }

        public Movie GetMovie(int id)
        {
            if (movies.Any(m => m.Id == id))
            {
                return movies.First(m => m.Id == id);
            }

            return null;
        }

        public bool InsertMovie(Movie movie)
        {
            movies.Add(movie);
            return true;
        }

        public bool UpdateMovie(int id, Movie movie)
        {
            if (movies.Any(m => m.Id == id))
            {
                var movieToUpdate = movies.First(m => m.Id == id);
                movieToUpdate.Name = movie.Name;
                movieToUpdate.Year = movie.Year;
                movieToUpdate.CountryId = movie.CountryId;
                return true;
            }

            return false;
        }

        public bool DeleteMovie(int id)
        {
            if (movies.Any(m => m.Id == id))
            {
                movies.Remove(movies.First(m => m.Id == id));
                return true;
            }

            return false;
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return countries.AsEnumerable();
        }

        public Country GetCountry(int id)
        {
            return countries.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return roles.AsEnumerable();
        }

        public Role GetRole(int id)
        {
            return roles.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return people.AsEnumerable();
        }

        public Person GetPerson(Guid id)
        {
            return people.FirstOrDefault(p => p.Id == id);
        }

        public bool InsertPerson(Person person)
        {
            people.Add(person);
            return true;
        }

        private void PreloadRoles()
        {
            roles.Add(new Role() { Id = 1, Name = "Lead actor" });
        }

        private void PreloadCountries()
        {
            countries.Add(new Country() { Id = 1, Name = "USA" });
        }

        private void PreloadPeople()
        {
            people.Add(new Person() { Id = Guid.NewGuid(), FullName = "Al Pacino" });
        }

        private void PreloadMovies()
        {
            var godFather = new Movie() { Id = 1, Name = "The Godfather", CountryId = 1, Country = countries.First(), Year = 1972 };
            godFather.Cast = new List<PersonRole>();
            godFather.Cast.Add(new PersonRole() { PersonId = 1, RoleId = 1 });
            movies.Add(godFather);

            movies.Add(new Movie()
            {
                Country = countries.First(),
                Name = "Goodfellas",
                Id = 2,
                Year = 1990,
                Cast = new List<PersonRole>() { new PersonRole() { PersonId = 2, RoleId = 1 } }
            });

            movies.Add(new Movie()
            {
                Country = countries.First(),
                Name = "Whiplash",
                Id = 3,
                Year = 2014,
                Cast = new List<PersonRole>() { new PersonRole() { PersonId = 3, RoleId = 1 } }
            });
        }
    }
}