using InfaktGateway.API;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Refit;

namespace InfaktGateway.Settings
{
    public static class InfaktGatewayBuilderExtensions
    {
        public static IServiceCollection AddInfaktGateway(this IServiceCollection services, IConfiguration configuration)
        {
            var apiUrl = configuration["InfaktGateway:ApiUrl"];
            if (apiUrl == null)
            {
                throw new ArgumentException("Missing InfaktGateway:ApiUrl in configuration");
            }

            services.AddRefitClient<IInfaktClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl))
                .AddHttpMessageHandler<AuthorizationHandler>();
            return services;
        }

        public static IApplicationBuilder UseInfaktGatewayEmailInvoiceExtractor(this IApplicationBuilder app)
        {
            var options = app.ApplicationServices.GetRequiredService<IOptions<InfaktGatewayOptions>>();
            var settings = options.Value;

            return app;
        }
    }
}
