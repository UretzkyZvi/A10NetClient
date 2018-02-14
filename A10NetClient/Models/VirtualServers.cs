using Newtonsoft.Json;
using System.Collections.Generic;

namespace A10NetClient.Models
{
    public partial class VirtualServers
    {
        [JsonProperty("virtual_server")]
        public VirtualServer VirtualServer { get; set; }
    }

    public partial class VirtualServer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("vrid")]
        public long Vrid { get; set; }

        [JsonProperty("arp_status")]
        public long ArpStatus { get; set; }

        [JsonProperty("stats_data")]
        public long StatsData { get; set; }

        [JsonProperty("extended_stats")]
        public long ExtendedStats { get; set; }

        [JsonProperty("disable_vserver_on_condition")]
        public long DisableVserverOnCondition { get; set; }

        [JsonProperty("redistribution_flagged")]
        public long RedistributionFlagged { get; set; }

        [JsonProperty("ha_group")]
        public HaGroup HaGroup { get; set; }

        [JsonProperty("vip_template")]
        public string VipTemplate { get; set; }

        [JsonProperty("pbslb_template")]
        public string PbslbTemplate { get; set; }

        [JsonProperty("vport_list")]
        public List<VportList> VportList { get; set; }
    }

    public partial class HaGroup
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("ha_group_id")]
        public long HaGroupId { get; set; }

        [JsonProperty("dynamic_server_weight")]
        public long DynamicServerWeight { get; set; }
    }

    public partial class VportList
    {
        [JsonProperty("protocol")]
        public long Protocol { get; set; }

        [JsonProperty("port")]
        public long Port { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("service_group")]
        public string ServiceGroup { get; set; }

        [JsonProperty("connection_limit")]
        public ConnectionLimit ConnectionLimit { get; set; }

        [JsonProperty("default_selection")]
        public long DefaultSelection { get; set; }

        [JsonProperty("received_hop")]
        public long ReceivedHop { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("stats_data")]
        public long StatsData { get; set; }

        [JsonProperty("extended_stats")]
        public long ExtendedStats { get; set; }

        [JsonProperty("snat_against_vip")]
        public long SnatAgainstVip { get; set; }

        [JsonProperty("vport_template")]
        public string VportTemplate { get; set; }

        [JsonProperty("vport_acl_id")]
        public long VportAclId { get; set; }

        [JsonProperty("aflex_list")]
        public object[] AflexList { get; set; }

        [JsonProperty("send_reset")]
        public long SendReset { get; set; }

        [JsonProperty("ha_connection_mirror")]
        public long HaConnectionMirror { get; set; }

        [JsonProperty("direct_server_return")]
        public long DirectServerReturn { get; set; }

        [JsonProperty("syn_cookie")]
        public SynCookie SynCookie { get; set; }

        [JsonProperty("source_nat")]
        public string SourceNat { get; set; }

        [JsonProperty("auto_source_nat")]
        public long AutoSourceNat { get; set; }

        [JsonProperty("auto_source_nat_precedence")]
        public long AutoSourceNatPrecedence { get; set; }

        [JsonProperty("tcp_template")]
        public string TcpTemplate { get; set; }

        [JsonProperty("source_ip_persistence_template")]
        public string SourceIpPersistenceTemplate { get; set; }

        [JsonProperty("ip_in_ip")]
        public long IpInIp { get; set; }

        [JsonProperty("pbslb_template")]
        public string PbslbTemplate { get; set; }

        [JsonProperty("acl_natpool_binding_list")]
        public object[] AclNatpoolBindingList { get; set; }
    }

    public partial class ConnectionLimit
    {
        [JsonProperty("status")]
        public long Status { get; set; }
    }

    public partial class SynCookie
    {
        [JsonProperty("syn_cookie")]
        public long SynCookieSynCookie { get; set; }

        [JsonProperty("sack")]
        public long Sack { get; set; }
    }

    public partial class VirtualServers
    {
        public static VirtualServers FromJson(string json)
        {
            return JsonConvert.DeserializeObject<VirtualServers>(json, A10NetClient.Models.Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this VirtualServers self)
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
