﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordFinderApi.Models
{
    public class ApiResponseModel
    {
        public List<string> Result { get; set; }

        public string ErrorMessage { get; set; }
    }
}
