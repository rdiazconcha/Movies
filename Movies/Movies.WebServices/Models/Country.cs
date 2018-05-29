using System.Runtime.Serialization;

namespace Movies.WebServices.Models
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}