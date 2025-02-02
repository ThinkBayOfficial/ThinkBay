using ThinkOwn.View.Signin_Out.ViewModel;

namespace ThinkOwn.View.Signin_Out;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		InitializeComponent();
        BindingContext = new ForgotPasswordViewModel();
    }
}