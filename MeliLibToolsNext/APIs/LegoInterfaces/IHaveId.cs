using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliLibToolsNext.APIs.LegoInterfaces
{
    public interface IHaveLongId: IHaveId<long?>
    {

    }
    public interface IHaveStringId: IHaveId<string?>
    {

    }
    public interface IHaveId<T>
    {
        [JsonProperty("id")]
        public  T Id { get; }
    }
}
