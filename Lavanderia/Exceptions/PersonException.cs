﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavanderia.Exceptions
{
    class PersonException : Exception
    {
        public PersonException(string msg) : base(msg)
        { 

        }
    }
}
