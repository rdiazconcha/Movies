using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using Movies.SoapWebServices.Interfaces;
using Movies.SoapWebServices.Models;
using Movies.SoapWebServices.Repositories;

namespace Movies.SoapWebServices
{
    /// <summary>
    ///     Summary description for PeopleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PeopleService : WebService
    {
        private readonly IMoviesRepository moviesRepository;

        public PeopleService()
        {
            moviesRepository = FakeMoviesRepository.Current;
        }

        [WebMethod]
        public List<Person> GetAllPeople()
        {
            return moviesRepository.GetAllPeople().ToList();
        }

        [WebMethod]
        public Person GetPerson(Guid id)
        {
            return moviesRepository.GetPerson(id);
        }

        [WebMethod]
        public bool InsertPerson(Person person)
        {
            return moviesRepository.InsertPerson(person);
        }
    }
}