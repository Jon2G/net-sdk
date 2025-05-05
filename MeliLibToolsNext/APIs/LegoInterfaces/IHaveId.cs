using Newtonsoft.Json;

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
