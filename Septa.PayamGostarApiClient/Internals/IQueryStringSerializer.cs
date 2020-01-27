﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace PayamGostarClient.Internals
{

    public interface IQueryStringSerializer
    {
        string Serialize(object obj);
    }
}
