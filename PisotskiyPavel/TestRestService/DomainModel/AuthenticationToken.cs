﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [DataContract]
    public class AuthenticationToken
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Token { get; set; }
    }
}