using System;
using System.Collections.Generic;
using Movies.WebServices.Models;

namespace Movies.WebServices
{
    public class MoviesService : IMoviesService
    {
        private IMoviesRepository moviesRepository;

        public MoviesService()
        {
            moviesRepository = FakeMoviesRepository.Current;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return moviesRepository.GetAllMovies();
        }

        public Movie GetMovie(int id)
        {
            return moviesRepository.GetMovie(id);
        }

        public bool InsertMovie(Movie movie)
        {
            return moviesRepository.InsertMovie(movie);
        }

        public bool UpdateMovie(int id, Movie movie)
        {
            return moviesRepository.UpdateMovie(id, movie);
        }

        public bool DeleteMovie(int id)
        {
            return moviesRepository.DeleteMovie(id);
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return moviesRepository.GetAllCountries();
        }

        public Country GetCountry(int id)
        {
            return moviesRepository.GetCountry(id);
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return moviesRepository.GetAllRoles();
        }

        public Role GetRole(int id)
        {
            return moviesRepository.GetRole(id);
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return moviesRepository.GetAllPeople();
        }

        public Person GetPerson(Guid id)
        {
            return moviesRepository.GetPerson(id);
        }

        public bool InsertPerson(Person person)
        {
            return moviesRepository.InsertPerson(person);
        }
    }
}