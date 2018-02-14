using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10NetClient.Methods
{
    public interface IMethod
    {
        string GETexecute(GETActionType method, Dictionary<string, string> queryParams);
        string POSTexecute(POSTActionType method, Dictionary<string, string> queryParams);
    }
}
