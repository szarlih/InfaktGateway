using InfaktGateway.API;
using InfaktGateway.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Refit;

namespace InfaktGateway.Settings;

public static class InfaktGatewayBuilderExtensions
{
    public static IServiceCollection AddInfaktGateway(this IServiceCollection services, IConfiguration configuration)
    {
        var apiUrl = configuration["InfaktGateway:ApiUrl"];
        if (apiUrl == null)
        {
            throw new ArgumentException("Missing InfaktGateway:ApiUrl in configuration");
        }

        services.AddTransient<AuthorizationHandler>();
        services.AddRefitClient<IInfaktClient>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl))
            .AddHttpMessageHandler<AuthorizationHandler>();
        services.AddTransient<IInfaktApiService, InfaktApiService>();
        return services;
    }

    public static IApplicationBuilder UseInfaktGatewayEmailInvoiceExtractor(this IApplicationBuilder app)
    {
        var options = app.ApplicationServices.GetRequiredService<IOptions<InfaktGatewayOptions>>();

        return app;
    }
}
