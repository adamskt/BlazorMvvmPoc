
namespace BlazorMvvmPoc.ViewModels;

public interface IViewModelBase : INotifyPropertyChanged
{
    Task OnInitializedAsync();
    bool IsBusy { get; }
    event EventHandler<bool> IsBusyChanged;

    IAsyncRelayCommand Loaded { get; }
}