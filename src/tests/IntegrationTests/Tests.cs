namespace LTX.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LtxClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LTX_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LTX_API_KEY environment variable is not found.");

        var client = new LtxClient(apiKey);
        
        return client;
    }
}
