using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using Movies.SoapWebServices.Interfaces;
using Movies.SoapWebServices.Models;
using Movies.SoapWebServices.Repositories;

namespace Movies.SoapWebServices
{
    /// <summary>
    ///     Summary description for CountriesService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CountriesService : WebService
    {
        private readonly IMoviesRepository moviesRepository;

        public CountriesService()
        {
            moviesRepository = FakeMoviesRepository.Current;
        }

        [WebMethod]
        public List<Country> GetAllCountries()
        {
            return moviesRepository.GetAllCountries().ToList();
        }

        [WebMethod]
        public Country GetCountry(int id)
        {
            return moviesRepository.GetCountry(id);
        }
    }
}