using BlazorMvvmPoc;
using BlazorMvvmPoc.ViewModels.Pages;
using BlazorMvvmPoc.ViewModels.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// ViewModels
builder.Services.AddTransient<BusySpinnerViewModel>();
builder.Services.AddTransient<NavMenuViewModel>();
builder.Services.AddTransient<CounterViewModel>();
builder.Services.AddTransient<FetchDataViewModel>();


await builder.Build().RunAsync();
