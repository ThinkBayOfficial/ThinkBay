
using Microsoft.Maui.ApplicationModel.Communication;
using System.Text.RegularExpressions;
using ThinkOwn.InterFaces;

using ThinkOwn.View.Signin_Out.ViewModel;

namespace ThinkOwn.View.Signin_Out.View;

public partial class SignUpView : ContentPage
{
    private IShowToast _showToast;
    public SignUpView(IShowToast showToast)
	{
		InitializeComponent();
        _showToast = showToast;
        BindingContext = new SignUpViewModel(_showToast);
        
    }

    private void EmailEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{1,}$");
        var email = e.NewTextValue;
        if (emailRegex.IsMatch(email))
        {
            EmailInfo.IsVisible = false;
          
        }
        else
        {
            EmailInfo.IsVisible = true;
        }
    }

    private void Passwords_TextChanged(object sender, TextChangedEventArgs e)
    {
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        var passwordregex = new Regex(pattern);
        var password = e.NewTextValue;
        if (passwordregex.IsMatch(password))
        {
            Passwordinfo.IsVisible = false;
        }
        else
        {
            Passwordinfo.IsVisible = true;
        }

    }
    private void Confirm_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (Passwords.Text == Confirm.Text)
        {
            Confirm.TextColor = Color.FromHex("#00FF00");
            ConfPasswordinfo.IsVisible = false;
            
        }
        else
        {
            Confirm.TextColor = Color.FromHex("#FF0000");
            ConfPasswordinfo.IsVisible = true;
            
        }
    }


}