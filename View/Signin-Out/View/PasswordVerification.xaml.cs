using ThinkBay.View.Signin_Out.ViewModel;

namespace ThinkBay.View.Signin_Out;

public partial class PasswordVerification : ContentPage
{
	public PasswordVerification()
	{
		InitializeComponent();
        BindingContext = new PasswordVerificationViewModel();
    }

    private void TextField_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (Passwords.Text == Confirm.Text)
        {
            Confirm.BorderColor = Color.FromHex("#00FF00");
        }
        else
        {
            Confirm.BorderColor = Color.FromHex("#FF0000");
        }

    }
}