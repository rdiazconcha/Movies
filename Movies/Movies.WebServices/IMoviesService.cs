using System;
using System.Collections.Generic;
using System.ServiceModel;
using Movies.WebServices.Models;

namespace Movies.WebServices
{
    [ServiceContract]
    public interface IMoviesService
    {
        [OperationContract]
        IEnumerable<Movie> GetAllMovies();

        [OperationContract]
        Movie GetMovie(int id);

        [OperationContract]
        bool InsertMovie(Movie movie);

        [OperationContract]
        bool UpdateMovie(int id, Movie movie);

        [OperationContract]
        bool DeleteMovie(int id);

        [OperationContract]
        IEnumerable<Country> GetAllCountries();

        [OperationContract]
        Country GetCountry(int id);

        [OperationContract]
        IEnumerable<Role> GetAllRoles();

        [OperationContract]
        Role GetRole(int id);

        [OperationContract]
        IEnumerable<Person> GetAllPeople();

        [OperationContract]
        Person GetPerson(Guid id);

        [OperationContract]
        bool InsertPerson(Person person);
    }
}