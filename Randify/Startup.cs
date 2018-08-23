using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using Randify.Services;
using Blazor.Extensions.Storage;
using Blazor.Extensions.Logging;
using Microsoft.Extensions.Logging;

namespace Randify
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<AuthenticationService>();
            services.AddSingleton<ConfigurationService>();
            services.AddSingleton<SpotifyService>();
            services.AddStorage();
            services.AddLogging(builder => builder
                .AddBrowserConsole()
                .SetMinimumLevel(LogLevel.Trace));
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
