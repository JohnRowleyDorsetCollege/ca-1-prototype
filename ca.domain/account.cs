﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ca.domain
{
    public class Account
    {
        public Account(string _name)
        {
            name = _name;
        }
        public string name { get; set; }
    }
}
