using System.Collections.ObjectModel;
using System.Net.Http.Json;
using BlazorMvvmPoc.Models;

namespace BlazorMvvmPoc.ViewModels.Pages;

public class FetchDataViewModel : ViewModelBase
{
    private readonly HttpClient _client;

    // DI !
    public FetchDataViewModel(HttpClient client)
    {
        _client = client;
    }

    public override async Task OnInitializedAsync()
    {
        IsBusy = true;
        Thread.Sleep(10000);
        WeatherForecast[]? forecasts = await _client.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        Forecasts = new ObservableCollection<WeatherForecast>(forecasts ?? Array.Empty<WeatherForecast>());
        IsBusy = false;
        await base.OnInitializedAsync();
    }

    public ObservableCollection<WeatherForecast> Forecasts { get; set; } = new();
}