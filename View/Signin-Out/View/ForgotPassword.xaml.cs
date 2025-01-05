using ThinkBay.View.Signin_Out.ViewModel;

namespace ThinkBay.View.Signin_Out;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		InitializeComponent();
        BindingContext = new ForgotPasswordViewModel();
    }
}