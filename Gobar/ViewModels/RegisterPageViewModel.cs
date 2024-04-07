using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gobar.ViewModels;

public partial class RegisterPageViewModel : ObservableObject
{
    [RelayCommand]
    private async Task GoToAuthenticationPage()
    {
        await Shell.Current.GoToAsync("/Authentication");
    }
    
    [RelayCommand]
    private async Task GoToLoginPage()
    {
        await Shell.Current.GoToAsync("..");
    }
}
