using System;
using System.Runtime.Serialization;

namespace Movies.WebServices.Models
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string FullName { get; set; }
    }
}