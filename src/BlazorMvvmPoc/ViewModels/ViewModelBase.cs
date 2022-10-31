using CommunityToolkit.Mvvm.ComponentModel;

namespace BlazorMvvmPoc.ViewModels;

// See https://learn.microsoft.com/en-us/windows/communitytoolkit/mvvm/introduction
public  abstract partial class ViewModelBase : ObservableObject, IViewModelBase
{
    [ObservableProperty]
    private bool _isBusy;

    protected ViewModelBase()
    {
        Loaded = new AsyncRelayCommand(OnLoadedAsync);
    }

    partial void OnIsBusyChanged(bool value)
    {
        IsBusyChanged?.Invoke(this, value);
    }

    public virtual async Task OnInitializedAsync()
    {
        await OnLoadedAsync().ConfigureAwait(true);
    }


    public event EventHandler<bool> IsBusyChanged = null!;


    public IAsyncRelayCommand Loaded { get; }

    public virtual async Task OnLoadedAsync()
    {
        await Task.CompletedTask.ConfigureAwait(false);
    }
}