using A10NetClient.Methods;
using A10NetClient.Methods.Implementation;
using A10NetClient.Models.Session;
using RestSharp;
using System;
using System.Collections.Generic;

namespace A10NetClient.Implementation
{

    public class Session
    {
        private static string Url;

        public static string Session_Id { get; set; }
        private static IRestResponse Response { get; set; }

        private Lazy<Service_Group> service_Group =
                 new Lazy<Service_Group>(() => new Service_Group(Session_Id, Url));

        private Lazy<Virtual_Server> virtual_server =
            new Lazy<Virtual_Server>(() => new Virtual_Server(Session_Id, Url));

        private Lazy<Server> server =
         new Lazy<Server>(() => new Server(Session_Id, Url));

        public Server Server
        {
            get
            {
                return server.Value;
            }
        }

        public Virtual_Server VirtualServer
        {
            get
            {
                return virtual_server.Value;
            }
        }

        public Service_Group ServiceGroup
        {
            get
            {
                return service_Group.Value;
            }
        }

        private Session(string url)
        {
            Url = url;
            Session_Id = RespoSesession.FromJson(Response.Content).SessionId;
        }

        public bool Close()
        {
            return RestHelper.GETRequest(Url+"?session_id="+Session_Id, MethodsVariables.Close, null).Content.Contains("OK");
        }
        private static bool HasError() =>
             Response.ErrorException != null;
        public static Session CreateSession(string url, string userName, string password)
        {

            Dictionary<string, string> paramters = new Dictionary<string, string>();
            paramters.Add("username", userName);
            paramters.Add("password", password);
            Response = RestHelper.POSTRequest(url, MethodsVariables.Authenticate, paramters);

            if (HasError())
                throw Response.ErrorException;

            return new Session(url);
        }
    }
}
