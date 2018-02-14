using System.Collections.Generic;
using Newtonsoft.Json;

namespace A10NetClient.Models.ServiceGroup
{


    public partial class ServicesGroup
    {
        [JsonProperty("service_group")]
        public ServiceGroup ServiceGroup { get; set; }
    }

    public partial class ServiceGroup
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("protocol")]
        public long Protocol { get; set; }

        [JsonProperty("lb_method")]
        public long LbMethod { get; set; }

        [JsonProperty("health_monitor")]
        public string HealthMonitor { get; set; }

        [JsonProperty("policy_template")]
        public string PolicyTemplate { get; set; }

        [JsonProperty("port_template")]
        public string PortTemplate { get; set; }

        [JsonProperty("server_template")]
        public string ServerTemplate { get; set; }

        [JsonProperty("priority_affinity")]
        public long PriorityAffinity { get; set; }

        [JsonProperty("sample_rsp_time")]
        public long SampleRspTime { get; set; }

        [JsonProperty("sample_rsp_time_rpt_ext_ser_top_fastest")]
        public long SampleRspTimeRptExtSerTopFastest { get; set; }

        [JsonProperty("sample_rsp_time_rpt_ext_ser_top_slowest")]
        public long SampleRspTimeRptExtSerTopSlowest { get; set; }

        [JsonProperty("sample_rsp_time_rpt_ext_ser_report_delay")]
        public long SampleRspTimeRptExtSerReportDelay { get; set; }

        [JsonProperty("traffic_repl_mirr_da_repl")]
        public long TrafficReplMirrDaRepl { get; set; }

        [JsonProperty("traffic_repl_mirr_sa_repl")]
        public long TrafficReplMirrSaRepl { get; set; }

        [JsonProperty("traffic_repl_mirr_sa_da_repl")]
        public long TrafficReplMirrSaDaRepl { get; set; }

        [JsonProperty("traffic_repl_mirr_ip_repl")]
        public long TrafficReplMirrIpRepl { get; set; }

        [JsonProperty("traffic_repl_mirr")]
        public long TrafficReplMirr { get; set; }

        [JsonProperty("action_list")]
        public List<ActionList> ActionList { get; set; }

        [JsonProperty("min_active_member")]
        public MinActiveMember MinActiveMember { get; set; }

        [JsonProperty("backup_server_event_log_enable")]
        public long BackupServerEventLogEnable { get; set; }

        [JsonProperty("client_reset")]
        public long ClientReset { get; set; }

        [JsonProperty("stats_data")]
        public long StatsData { get; set; }

        [JsonProperty("extended_stats")]
        public long ExtendedStats { get; set; }

        [JsonProperty("member_list")]
        public List<MemberList> MemberList { get; set; }
    }

    public partial class ActionList
    {
        [JsonProperty("action")]
        public long Action { get; set; }

        [JsonProperty("exceed_limit_only")]
        public long ExceedLimitOnly { get; set; }
    }

    public partial class MemberList
    {
        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("port")]
        public long Port { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("priority")]
        public long Priority { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("stats_data")]
        public long StatsData { get; set; }
    }

    public partial class MinActiveMember
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("priority_set")]
        public long PrioritySet { get; set; }
    }

    public partial class ServicesGroup
    {
        public static ServicesGroup FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ServicesGroup>(json, A10NetClient.Models.Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this ServicesGroup self)
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
