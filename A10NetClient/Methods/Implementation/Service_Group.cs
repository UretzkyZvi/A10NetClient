using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10NetClient.Methods
{
    public class Service_Group : SLB
    {
        private string BaseUrl;

        public Service_Group(string session_Id)
        {
            SessionId = session_Id;
        }

        public Service_Group(string session_Id, string url) : this(session_Id)
        {
            BaseUrl = url;
        }
        public override string GETexecute(GETActionType action, Dictionary<string, string> queryParams)
        {
            return RestHelper.GETRequest(BaseUrl + "?session_id=" + SessionId,
                 Name + "." + MethodsVariables.ServiceGroup + "." + action.ToString(),
                 queryParams).Content;
        }
   
    }
}
