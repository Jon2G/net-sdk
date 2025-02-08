﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveStatus<T>
    {
        [JsonProperty("status")]
        T? Status { get; set;}
    }

    public interface IHaveLongStatus : IHaveStatus<long>
    {
    }
    public interface IHaveStringStatus : IHaveStatus<string>
    {
    }
}
