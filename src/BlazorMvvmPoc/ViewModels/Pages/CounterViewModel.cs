using CommunityToolkit.Mvvm.ComponentModel;

namespace BlazorMvvmPoc.ViewModels.Pages;

public partial class CounterViewModel : ViewModelBase
{
    [ObservableProperty]
    private long _counter;

    [RelayCommand]
    private void IncrementCount()
    {
        _counter++;
    }
}