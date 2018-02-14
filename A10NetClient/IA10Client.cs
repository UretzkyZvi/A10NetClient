using A10NetClient.Implementation;

namespace A10NetClient
{
    public interface IA10Client
    {
        string UserName { get; }
        string A10IpAddress { get; }
        Session Session { get; set; }
    }
}
