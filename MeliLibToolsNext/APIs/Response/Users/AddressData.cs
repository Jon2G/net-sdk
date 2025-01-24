using Newtonsoft.Json;

namespace MeliLibToolsNext.APIs.Response.Users;

 public class City
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Country
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }




    public class Municipality
    {
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }
    }

    public class Neighborhood
    {
        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OnHolidays
    {
        [JsonProperty("hours")]
        public List<object> Hours { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class OpenHours
    {
        [JsonProperty("monday")]
        public List<OpenHoursDay> Monday { get; set; }

        [JsonProperty("tuesday")]
        public List<OpenHoursDay> Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public List<OpenHoursDay> Wednesday { get; set; }

        [JsonProperty("thursday")]
        public List<OpenHoursDay> Thursday { get; set; }

        [JsonProperty("friday")]
        public List<OpenHoursDay> Friday { get; set; }

        [JsonProperty("saturday")]
        public List<OpenHoursDay> Saturday { get; set; }

        [JsonProperty("sunday")]
        public List<OpenHoursDay> Sunday { get; set; }

        [JsonProperty("on_holidays")]
        public OnHolidays OnHolidays { get; set; }
    }

    public class AddressData
{
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("location_id")]
        public object LocationId { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address_line")]
        public string AddressLine { get; set; }

        [JsonProperty("floor")]
        public object Floor { get; set; }

        [JsonProperty("apartment")]
        public object Apartment { get; set; }

        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }

        [JsonProperty("street_name")]
        public string StreetName { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("state")]
        public State State { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("neighborhood")]
        public Neighborhood Neighborhood { get; set; }

        [JsonProperty("municipality")]
        public Municipality Municipality { get; set; }

        [JsonProperty("search_location")]
        public SearchLocation SearchLocation { get; set; }

        [JsonProperty("types")]
        public List<object> Types { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("between")]
        public object Between { get; set; }

        [JsonProperty("references")]
        public object References { get; set; }

        [JsonProperty("aditional_info")]
        public string AditionalInfo { get; set; }

        [JsonProperty("geolocation_type")]
        public string GeolocationType { get; set; }

        [JsonProperty("geolocation_last_updated")]
        public DateTime? GeolocationLastUpdated { get; set; }

        [JsonProperty("geolocation_source")]
        public string GeolocationSource { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("normalized")]
        public bool? Normalized { get; set; }

        [JsonProperty("open_hours")]
        public OpenHours OpenHours { get; set; }

        [JsonProperty("address_type")]
        public string AddressType { get; set; }

        [JsonProperty("scoring")]
        public int? Scoring { get; set; }
    }



    public class SearchLocation
    {
        [JsonProperty("state")]
        public State State { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("neighborhood")]
        public Neighborhood Neighborhood { get; set; }
    }

    public class State
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OpenHoursDay
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }
