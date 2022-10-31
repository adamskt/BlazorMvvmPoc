using CommunityToolkit.Mvvm.ComponentModel;

namespace BlazorMvvmPoc.Models;

public partial class WeatherForecast : ObservableObject
{
    [ObservableProperty]
    private DateTime _date;

    [ObservableProperty]
    private double _temperatureC;

    [ObservableProperty]
    private string? _summary;

    public double TemperatureF => 32.0 + TemperatureC / 0.5556;
}