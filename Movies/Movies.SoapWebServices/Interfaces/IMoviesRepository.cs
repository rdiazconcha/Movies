using System;
using System.Collections.Generic;
using Movies.SoapWebServices.Models;

namespace Movies.SoapWebServices.Interfaces
{
    public interface IMoviesRepository
    {
        IEnumerable<Movie> GetAllMovies();

        Movie GetMovie(int id);

        bool InsertMovie(Movie movie);

        bool UpdateMovie(int id, Movie movie);

        bool DeleteMovie(int id);

        IEnumerable<Country> GetAllCountries();

        Country GetCountry(int id);

        IEnumerable<Role> GetAllRoles();

        Role GetRole(int id);

        IEnumerable<Person> GetAllPeople();

        Person GetPerson(Guid id);

        bool InsertPerson(Person person);
    }
}