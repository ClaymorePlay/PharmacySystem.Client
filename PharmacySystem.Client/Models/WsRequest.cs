﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.Client.Models
{
    public class WsRequest
    {

        public string controller { get; set; }

        public string method { get; set; }

        public string value { get; set; }

    }
}
