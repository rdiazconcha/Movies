using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Movies.WebServices.Models
{
    [DataContract]
    public class Movie
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public Country Country { get; set; }

        [DataMember]
        public List<PersonRole> Cast { get; set; }
    }
}