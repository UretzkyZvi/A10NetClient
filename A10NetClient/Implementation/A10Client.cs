using A10NetClient.Implementation;
using A10NetClient.Methods;
using System;
using System.Collections.Generic;

namespace A10NetClient.Implementation
{

    public class A10Client : IA10Client
    {



        public string UserName { get; }
        public string A10IpAddress { get; }
        public string aXAPI_URL_V2_HTTPS { get; }
        public  Session Session { get; set; }

        public A10Client(string userName, string password, string a10IpAddress, A10ClientVersion version)
        {
            UserName = userName;
            A10IpAddress = a10IpAddress;
            switch (version)
            {
                case A10ClientVersion.V2:
                    aXAPI_URL_V2_HTTPS = 
                        string.Format("https://{0}:{1}/services/rest/V2/", A10IpAddress, GlobalVariables.aXAPI_Port_Https);
                    break;
                case A10ClientVersion.V3:
                    break;
                default:
                    break;
            }
            Session = Session.CreateSession(aXAPI_URL_V2_HTTPS, UserName, password);
        }

        internal static IA10Client Instance(string userName, string password, string a10IpAddress, A10ClientVersion version)
        {
            return new A10Client(userName, password, a10IpAddress, version);
        }
    }
}
