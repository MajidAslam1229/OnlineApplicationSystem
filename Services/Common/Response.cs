﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanStructure.Services.Common
{
    public class Response<T> where T : class
    {
        public bool IsException { get; set; }
        public string Messages { get; set; }
        public T Data { get; set; }
    }
}
