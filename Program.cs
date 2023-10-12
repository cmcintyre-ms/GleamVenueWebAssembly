using GleamVenueWebAssembly;
using GleamVenueWebAssembly.Services.GleamVenueService;
using Majorsoft.Blazor.Components.Common.JsInterop.Geo;
using Majorsoft.Blazor.Components.Maps.Google;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IGleamVenueService, GleamVenueService>(client => client.BaseAddress = new Uri("https://localhost:7179/"));

builder.Services.AddScoped<IGeolocationService, GeolocationService>();

builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    options.ProviderOptions.LoginMode = "redirect";
    options.ProviderOptions.DefaultAccessTokenScopes.Add("https://graph.microsoft.com/User.Read");
});

builder.Services.AddGleamVenueClient().ConfigureHttpClient(client =>
    client.BaseAddress = new Uri("https://localhost:7179/graphql/"));

await builder.Build().RunAsync();
