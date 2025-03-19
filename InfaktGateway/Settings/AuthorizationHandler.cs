using Microsoft.Extensions.Options;
using System.Net.Http.Headers;

namespace InfaktGateway.Settings;

public class AuthorizationHandler : DelegatingHandler
{
    private readonly InfaktGatewayOptions _options;
    private readonly string _apiKeyHeader = "X-inFakt-ApiKey";

    public AuthorizationHandler(IOptions<InfaktGatewayOptions> options)
    {
        _options = options.Value;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancelToken)
    {
        HttpRequestHeaders headers = request.Headers;
        headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var authHeaderExists = headers.TryGetValues(_apiKeyHeader, out IEnumerable<string>? apiKey);

        if (!authHeaderExists)
        {
            headers.Add(_apiKeyHeader, _options.ApiKey);
        }

        return await base.SendAsync(request, cancelToken);
    }
}
