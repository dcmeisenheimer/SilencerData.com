using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;
using SilencerData.Client;
using SilencerData.Client.Interfaces;
using SilencerData.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ISilencerDataService, SilencerDataService>();

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopRight;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 3000;
    //config.SnackbarConfiguration.MaxDisplayedSnackbars = 1;
});
builder.Services.AddBlazoredLocalStorageAsSingleton(); // Source: https://github.com/Blazored/LocalStorage
builder.Services.AddSingleton<ThemeState>();

await builder.Build().RunAsync();
