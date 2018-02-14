using System.Collections.Generic;
using Newtonsoft.Json;
namespace A10NetClient.Models.Server
{
    public partial class Servers
    {
        [JsonProperty("server")]
        public Server Server { get; set; }
    }

    public partial class Server
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("gslb_external_address")]
        public string GslbExternalAddress { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("health_monitor")]
        public string HealthMonitor { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("conn_limit")]
        public long ConnLimit { get; set; }

        [JsonProperty("conn_limit_log")]
        public long ConnLimitLog { get; set; }

        [JsonProperty("conn_resume")]
        public long ConnResume { get; set; }

        [JsonProperty("stats_data")]
        public long StatsData { get; set; }

        [JsonProperty("extended_stats")]
        public long ExtendedStats { get; set; }

        [JsonProperty("slow_start")]
        public long SlowStart { get; set; }

        [JsonProperty("spoofing_cache")]
        public long SpoofingCache { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("port_list")]
        public List<PortList> PortList { get; set; }
    }

    public partial class PortList
    {
        [JsonProperty("port_num")]
        public long PortNum { get; set; }

        [JsonProperty("protocol")]
        public long Protocol { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("no_ssl")]
        public long NoSsl { get; set; }

        [JsonProperty("conn_limit")]
        public long ConnLimit { get; set; }

        [JsonProperty("conn_limit_log")]
        public long ConnLimitLog { get; set; }

        [JsonProperty("conn_resume")]
        public long ConnResume { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("stats_data")]
        public long StatsData { get; set; }

        [JsonProperty("health_monitor")]
        public string HealthMonitor { get; set; }

        [JsonProperty("extended_stats")]
        public long ExtendedStats { get; set; }

        [JsonProperty("server_ssl_template")]
        public string ServerSslTemplate { get; set; }
    }

    public partial class Servers
    {
        public static Servers FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Servers>(json, A10NetClient.Models.Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this Servers self)
        {
            return JsonConvert.SerializeObject(self, A10NetClient.Models.Converter.Settings);
        }
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
