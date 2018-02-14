using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10NetClient.Models.VirtualServerList
{
    public partial class VirtualServerList
    {
        [JsonProperty("virtual_server_list")]
        public VirtualServerListElement[] VirtualServerListVirtualServerList { get; set; }
    }

    public partial class VirtualServerListElement
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

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
        public VportList[] VportList { get; set; }
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

        [JsonProperty("aflex_list")]
        public object[] AflexList { get; set; }

        [JsonProperty("send_reset")]
        public long SendReset { get; set; }

        [JsonProperty("sack")]
        public long? Sack { get; set; }

        [JsonProperty("source_nat")]
        public string SourceNat { get; set; }

        [JsonProperty("http_template")]
        public string HttpTemplate { get; set; }

        [JsonProperty("tcp_template")]
        public string TcpTemplate { get; set; }

        [JsonProperty("conn_reuse_template")]
        public string ConnReuseTemplate { get; set; }

        [JsonProperty("source_ip_persistence_template")]
        public string SourceIpPersistenceTemplate { get; set; }

        [JsonProperty("pbslb_template")]
        public string PbslbTemplate { get; set; }

        [JsonProperty("acl_natpool_binding_list")]
        public AclNatpoolBindingList[] AclNatpoolBindingList { get; set; }

        [JsonProperty("sync_cookie")]
        public SyncCookie SyncCookie { get; set; }

        [JsonProperty("server_ssl_template")]
        public string ServerSslTemplate { get; set; }

        [JsonProperty("tcp_proxy_template")]
        public string TcpProxyTemplate { get; set; }

        [JsonProperty("sip_template")]
        public string SipTemplate { get; set; }

        [JsonProperty("ram_cache_template")]
        public string RamCacheTemplate { get; set; }
    }

    public partial class AclNatpoolBindingList
    {
        [JsonProperty("acl_id")]
        public long AclId { get; set; }

        [JsonProperty("nat_pool")]
        public string NatPool { get; set; }
    }

    public partial class ConnectionLimit
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("connection_limit")]
        public long ConnectionLimitConnectionLimit { get; set; }

        [JsonProperty("connection_limit_action")]
        public long ConnectionLimitAction { get; set; }

        [JsonProperty("connection_limit_log")]
        public long ConnectionLimitLog { get; set; }
    }

    public partial class SyncCookie
    {
        [JsonProperty("sync_cookie")]
        public long SyncCookieSyncCookie { get; set; }

        [JsonProperty("sack")]
        public long Sack { get; set; }
    }

    public partial class VirtualServerList
    {
        public static VirtualServerList FromJson(string json)
        {
            return JsonConvert.DeserializeObject<VirtualServerList>(json, Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this VirtualServerList self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
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
