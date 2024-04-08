using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Gobar.Models;
using Gobar.Views;

namespace Gobar.ViewModels;

public partial class OnboardingPageViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<OnboardingModel> _carouselItems = new ObservableCollection<OnboardingModel>();

    public OnboardingPageViewModel()
    {
        CarouselItems.Add(new OnboardingModel
        {
            ImageSource = "picture_on_1.png", 
            Title = "Welcome Gobars", 
            Description = "Find the best grooming experience in your city with just one tap! Don't miss out on the haircut or treatment of your dreams. Let's start now!"
        });
        CarouselItems.Add(new OnboardingModel
        {
            ImageSource = "picture_on_2.png", 
            Title = "Loooking for barber?", 
            Description = "Find the best barbershop around you in seconds, make an appointment, and enjoy the best grooming experience."
        });
        CarouselItems.Add(new OnboardingModel
        {
            ImageSource = "picture_on_3.png", 
            Title = "Everything in your hands", 
            Description = "With Gobar, find high-quality barbershops, see reviews, and make appointments easily. Achieve your confident appearance!"
        });
    }

    [RelayCommand]
    private void GoToLogin()
    {
        Application.Current.MainPage = new AppShell();
    }
}