﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveUrl
    {
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
