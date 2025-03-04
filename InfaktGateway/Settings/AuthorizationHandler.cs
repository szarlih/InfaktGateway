using Microsoft.Extensions.Options;
using System.Net.Http.Headers;

namespace InfaktGateway.Settings;

public class AuthorizationHandler : DelegatingHandler
{
    private readonly InfaktGatewayOptions _options;

    public AuthorizationHandler(IOptions<InfaktGatewayOptions> options)
    {
        _options = options.Value;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancelToken)
    {
        HttpRequestHeaders headers = request.Headers;

        AuthenticationHeaderValue authHeader = headers.Authorization;

        if (authHeader != null)
        {
            headers.Authorization = new AuthenticationHeaderValue(authHeader.Scheme, _options.ApiKey);
        }

        return await base.SendAsync(request, cancelToken);
    }
}
