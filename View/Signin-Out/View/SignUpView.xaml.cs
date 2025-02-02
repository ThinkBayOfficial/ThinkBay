using ThinkOwn.View.Signin_Out.ViewModel;

namespace ThinkOwn.View.Signin_Out.View;

public partial class SignUpView : ContentPage
{
	public SignUpView()
	{
		InitializeComponent();
        BindingContext = new SignUpViewModel();
    }

    private void Confirm_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (Passwords.Text == Confirm.Text)
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