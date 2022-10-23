using Microsoft.AspNetCore.Components;

namespace BlazorMvvmPoc.ViewModels;

public abstract class ComponentBase<TViewModel> : ComponentBase
    where TViewModel : IViewModelBase
{
    [Inject]
#pragma warning disable CS8618
    protected TViewModel ViewModel { get; set; }
#pragma warning restore CS8618

    protected override void OnInitialized()
    {
        ViewModel.PropertyChanged += (_, _) => StateHasChanged();
        ViewModel.IsBusyChanged += (_, isBusy) =>
        {
            if (isBusy)
            {
                // Show some global spinner here
            }
            // Hide the global spinner
        };
        base.OnInitialized();
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        return base.OnAfterRenderAsync(firstRender);
    }

    protected override Task OnInitializedAsync()
    {
        return ViewModel.OnInitializedAsync();
    }
}