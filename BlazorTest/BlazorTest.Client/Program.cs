using BlazorTest.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddTransient<IBackendClient, BackendClient>();

await builder.Build().RunAsync();
