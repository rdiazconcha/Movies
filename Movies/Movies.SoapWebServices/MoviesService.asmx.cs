using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using Movies.SoapWebServices.Interfaces;
using Movies.SoapWebServices.Models;
using Movies.SoapWebServices.Repositories;

namespace Movies.SoapWebServices
{
    /// <summary>
    ///     Summary description for MoviesService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MoviesService : WebService
    {
        private readonly IMoviesRepository moviesRepository;

        public MoviesService()
        {
            moviesRepository = FakeMoviesRepository.Current;
        }

        [WebMethod]
        public List<Movie> GetAllMovies()
        {
            return moviesRepository.GetAllMovies().ToList();
        }

        [WebMethod]
        public Movie GetMovie(int id)
        {
            return moviesRepository.GetMovie(id);
        }

        [WebMethod]
        public bool InsertMovie(Movie movie)
        {
            return moviesRepository.InsertMovie(movie);
        }

        [WebMethod]
        public bool UpdateMovie(int id, Movie movie)
        {
            return moviesRepository.UpdateMovie(id, movie);
        }

        [WebMethod]
        public bool DeleteMovie(int id)
        {
            return moviesRepository.DeleteMovie(id);
        }
    }
}