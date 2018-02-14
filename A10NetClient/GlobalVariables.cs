using System;
using System.Configuration;

namespace A10NetClient
{
    public enum GETActionType
    {
        getAll,
        search
    }
    public enum POSTActionType
    {
        create,
        update,
        delete
    }

    public enum A10ClientVersion
    {
        V2,
        V3
    }
    public static class GlobalVariables
    {
        /*
        To use HTTP, you must disable HTTP-to-HTTPS redirection on the AX device. 
        In the CLI, use the no web-service auto-redir command at the global configuration level of the CLI. 
        In the GUI, select Config > System > Settings.
        On the Web tab, de-select the Re-direct HTTP to HTTPS checkbox. Click OK. 
        */
        public static readonly string aXAPI_VersionV2 = "v2";
        public static readonly string aXAPI_Port_Https = "443";
        public static readonly string aXAPI_Port_Http = "80";

        public static readonly string aXAPI_format_Json = "json";
        public static readonly string aXAPI_format_Url = "url";
        public static readonly string aXAPI_format_Xml = "xml";


    }
}
