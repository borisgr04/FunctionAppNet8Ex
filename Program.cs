using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddSingleton<IOpenApiConfigurationOptions>(_ =>
        {
            var options = new OpenApiConfigurationOptions()
            {
                Info = new OpenApiInfo()
                {
                    Version = "1.0.0",
                    Title = "Swagger Petstore",
                    Description = "This is a sample server Petstore API designed by [http://swagger.io](http://swagger.io).",
                    TermsOfService = new Uri("https://github.com/Azure/azure-functions-openapi-extension"),
                    Contact = new OpenApiContact()
                    {
                        Name = "Enquiry",
                        Email = "azfunc-openapi@microsoft.com",
                        Url = new Uri("https://github.com/Azure/azure-functions-openapi-extension/issues"),
                    },
                    License = new OpenApiLicense()
                    {
                        Name = "MIT",
                        Url = new Uri("http://opensource.org/licenses/MIT"),
                    }
                },
                Servers = DefaultOpenApiConfigurationOptions.GetHostNames(),
                OpenApiVersion = OpenApiVersionType.V2,
                IncludeRequestingHostName = true,
                ForceHttps = false,
                ForceHttp = false,
            };

            return options;
        });
    })
    .Build();

host.Run();


//https://github.com/Azure/azure-functions-openapi-extension/blob/main/docs/openapi-out-of-proc.md