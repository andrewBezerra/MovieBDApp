using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MovieDBApp.Models
{
    [DataContract]
    public sealed class Genre
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }
    }
}
