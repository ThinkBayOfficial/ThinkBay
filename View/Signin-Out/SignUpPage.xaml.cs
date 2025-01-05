using Mopups.Interfaces;
using Mopups.Services;
using System.ComponentModel.DataAnnotations;
using ThinkBay.Behaviours;
using ThinkBay.Popupu.View;
 

namespace ThinkBay.View.Signin_Out;

public partial class SignUpPage : ContentPage
{
    IPopupNavigation popupNavigation;
    public SignUpPage()
	{
		InitializeComponent();
        
        //BindingContext = new SignUpViewModel();
      
    }

   

    private void Button_Clicked(object sender, EventArgs e)
    {
        Mopups.Services.MopupService.Instance.PushAsync(new SignUpOTPPage());
    }

    private void Confirm_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(Passwords.Text == Confirm.Text)
        {
            Confirm.TextColor = Color.FromHex("#00FF00");
            //Passwords.TextColor= Color.FromHex("#00FF00");
        }
        else
        {
            Confirm.TextColor = Color.FromHex("#FF0000");
            //Passwords.TextColor = Color.FromHex("#FF0000");
        }
    }
}