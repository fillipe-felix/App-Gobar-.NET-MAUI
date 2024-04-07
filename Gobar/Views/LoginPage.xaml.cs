using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobar.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }
    
    private void Button_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("", "Hello World", "Cancel");
    }
}

