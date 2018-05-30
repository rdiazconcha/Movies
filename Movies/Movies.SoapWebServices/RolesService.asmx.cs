using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using Movies.SoapWebServices.Interfaces;
using Movies.SoapWebServices.Models;
using Movies.SoapWebServices.Repositories;

namespace Movies.SoapWebServices
{
    /// <summary>
    ///     Summary description for RolesService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RolesService : WebService
    {
        private readonly IMoviesRepository moviesRepository;

        public RolesService()
        {
            moviesRepository = FakeMoviesRepository.Current;
        }

        [WebMethod]
        public List<Role> GetAllRoles()
        {
            return moviesRepository.GetAllRoles().ToList();
        }

        [WebMethod]
        public Role GetRole(int id)
        {
            return moviesRepository.GetRole(id);
        }
    }
}