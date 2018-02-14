using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10NetClient.Methods
{
    public abstract class SLB : IMethod
    {
        public string Name { get; private set; } = "slb";
        public string SessionId { get; set; }

        public virtual string GETexecute(GETActionType action, Dictionary<string, string> queryParams)
        {
            throw new NotImplementedException();
        }

        public virtual string POSTexecute(POSTActionType action, Dictionary<string, string> queryParams)
        {
            throw new NotImplementedException();
        }

    }
}
