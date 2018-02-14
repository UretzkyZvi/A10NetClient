using Newtonsoft.Json;
namespace A10NetClient.Models.Session
{

    public partial class RespoSesession
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
    }

    public partial class RespoSesession
    {
        public static RespoSesession FromJson(string json) => JsonConvert.DeserializeObject<RespoSesession>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RespoSesession self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
