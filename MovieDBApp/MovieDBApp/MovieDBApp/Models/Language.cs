﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MovieDBApp.Models
{
    [DataContract]
    public class Language
    {
        [DataMember(Name = "iso_639_1")]
        public string Iso639Code { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
