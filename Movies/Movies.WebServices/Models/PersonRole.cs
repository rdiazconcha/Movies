using System.Runtime.Serialization;

namespace Movies.WebServices.Models
{
    [DataContract]
    public class PersonRole
    {
        [DataMember]
        public int PersonId { get; set; }

        [DataMember]
        public int RoleId { get; set; }
    }
}