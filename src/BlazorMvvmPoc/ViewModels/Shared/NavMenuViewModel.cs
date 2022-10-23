using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorMvvmPoc.ViewModels.Shared;

public partial class NavMenuViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _menuCollapsed = true;

    [RelayCommand]
    private async Task ToggleNavMenu(MouseEventArgs args)
    {
        _menuCollapsed = !_menuCollapsed;
        await Task.CompletedTask.ConfigureAwait(false);
    }
}