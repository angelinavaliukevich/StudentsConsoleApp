﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    interface IValidator
    {
        public bool Validate();
        public string ErrorMessage { get; set;}
    }
}
