using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gobar.ViewModels;

public partial class LoginPageViewModel : ObservableObject
{
    [RelayCommand]
    private async Task GoToRegisterPage()
    {
        await Shell.Current.GoToAsync("/Register");
    }
    
    [RelayCommand]
    private async Task GoToForgotPasswordPage()
    {
        await Shell.Current.GoToAsync("/ForgotPassword");
    }
}
