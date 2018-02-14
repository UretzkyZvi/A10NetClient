using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace A10NetClient
{
    internal class RestHelper
    {

        public static IRestResponse GETRequest(string url, string method, Dictionary<string, string> paramters)
        {
            string URL = URLStringOrganizer(url, method, paramters);
            var client = new RestClient(URL);
            var request = new RestRequest(Method.GET);
            ServicePointManager.ServerCertificateValidationCallback +=
                 (sender, certificate, chain, sslPolicyErrors) => true;
            request.AddHeader("cache-control", "no-cache");
            return client.Execute(request);
        }
        public static IRestResponse POSTRequest(string url, string method, Dictionary<string, string> paramters)
        {
            string URL = URLStringOrganizer(url, method);
            var client = new RestClient(URL);
            ServicePointManager.ServerCertificateValidationCallback +=
                  (sender, certificate, chain, sslPolicyErrors) => true;
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddParameter("body",
                JsonConvert.SerializeObject(paramters, Formatting.Indented),
                ParameterType.RequestBody);

            return client.Execute(request);
        }
        private static string URLStringOrganizer(string url, string method, Dictionary<string, string> paramters = null)
        {
            string tempBaseUrl = "";
            if (url.Contains("?"))
            {
                tempBaseUrl = url + "&method=" + method;
            }
            else
            {
                tempBaseUrl = url + "?method=" + method;
            }
            
            string tempParam = "";
            if (paramters != null)
            {
                foreach (string paramKey in paramters.Keys)
                {
                    tempParam = tempParam + string.Format("&{0}={1}", paramKey, paramters[paramKey]);
                }
            }
            return tempBaseUrl + tempParam + "&format=" + GlobalVariables.aXAPI_format_Json;

        }
    }
}
