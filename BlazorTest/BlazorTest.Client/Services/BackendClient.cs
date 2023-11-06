namespace BlazorTest.Client.Services;

public class BackendClient : IBackendClient
{
    public bool IsClientSide()
    {
        return true;
    }
}