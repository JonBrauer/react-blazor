using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorChatApp.Core;

namespace BlazorChatApp
{
    public class Program
    {
        // public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
        //     BlazorWebAssemblyHost.CreateDefaultBuilder()
        //         .UseBlazorStartup<Startup>();

        // public static void Main(string[] args)
        // {
        //     CreateHostBuilder(args).Build().Run();
        // }

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#blazor-app");
            builder.Services.AddSingleton<ChatMessageRepository>();
            // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            // builder.Services.AddTransient<UserEntityRoleService, UserEntityRoleService>();
            // builder.Services.AddOptions();
            // builder.Services.AddAuthorizationCore();
            // builder.Services.AddScoped<ICustomTokenProvider, ClientBasedTokenProvider>();
            // builder.Services.AddDevExpressBlazor();
            // builder.Services.AddSingleton<WeatherForecastService>();
            await builder.Build().RunAsync();
        }

    }

    
}