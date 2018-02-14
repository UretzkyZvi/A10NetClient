using A10NetClient.Implementation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A10NetClient
{
    public class A10ClientBuilder
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private string A10IpAddress { get; set; }
        private bool ValidIp(string a10IpAddress)
        {
            if (a10IpAddress == string.Empty)
            {
                a10IpAddress = ConfigurationManager
                    .AppSettings["aXAPI_IPAddress"].ToString();
            }
            IPAddress ip;
            return IPAddress.TryParse(a10IpAddress, out ip);
        }

        public void Authentication(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public void IpAddress(string IpAddress)
        {
            A10IpAddress = IpAddress;
        }

        private bool CanBuild() =>
            UserName != string.Empty &&
            Password != string.Empty &&
            ValidIp(A10IpAddress);

        public IA10Client Build()
        {
            if (!this.CanBuild())
                throw new InvalidOperationException();
            return A10Client.Instance(UserName, Password, A10IpAddress, A10ClientVersion.V2);
        }

    }
}
