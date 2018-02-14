using System.Collections.Generic;
using A10NetClient;
using A10NetClient.Methods;

namespace A10NetClient.Methods
{

    public class Virtual_Server : SLB
    {
        private string BaseUrl;

        public Virtual_Server(string session_Id)
        {
            SessionId = session_Id;
        }

        public Virtual_Server(string session_Id, string url) : this(session_Id)
        {
            BaseUrl = url;
        }
        public override string GETexecute(GETActionType action, Dictionary<string, string> queryParams)
        {
            return RestHelper.GETRequest(BaseUrl + "?session_id=" + SessionId,
                Name + "." + MethodsVariables.VirtualServer + "." + action.ToString(),
                queryParams).Content;
        }
    }
}