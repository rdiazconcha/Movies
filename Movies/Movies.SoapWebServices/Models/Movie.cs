using System.Collections.Generic;

namespace Movies.SoapWebServices.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public List<PersonRole> Cast { get; set; }
    }
}