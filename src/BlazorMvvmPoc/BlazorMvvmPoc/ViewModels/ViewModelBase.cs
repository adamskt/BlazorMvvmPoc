using CommunityToolkit.Mvvm.ComponentModel;

namespace BlazorMvvmPoc.ViewModels;

// See https://learn.microsoft.com/en-us/windows/communitytoolkit/mvvm/introduction
public abstract class ViewModelBase : ObservableObject, IViewModelBase
{
    private bool _isBusy;

    protected ViewModelBase()
    {
        Loaded = new AsyncRelayCommand(OnLoadedAsync);
    }

    public virtual async Task OnInitializedAsync()
    {
        await OnLoadedAsync().ConfigureAwait(true);
    }

    public virtual bool IsBusy
    {
        get => _isBusy;
        protected set
        {
            SetProperty(ref _isBusy, value);
            OnIsBusyChanged(_isBusy);
        }
    }

    public event EventHandler<bool> IsBusyChanged = null!;


    public IAsyncRelayCommand Loaded { get; }

    protected void OnIsBusyChanged(bool isBusy)
    {
        IsBusyChanged?.Invoke(this, isBusy);
    }

    public virtual async Task OnLoadedAsync()
    {
        await Task.CompletedTask.ConfigureAwait(false);
    }
}