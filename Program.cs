using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BalatroHub;
using BalatroHub.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Standard Blazor Root Components
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after"); // Use .Add instead of .RegisterCustomElement

// Register the HttpClient (Standard)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register our Custom AppState Service for tracking deck clicks
builder.Services.AddScoped<AppState>();

await builder.Build().RunAsync();