using BlazorTest.Client.Services;

namespace BlazorTest.Services;

public class ServerSideBackendClient : IBackendClient
{
    public bool IsClientSide()
    {
        return false;
    }
}