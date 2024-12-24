using ThinkBay.ViewModel;

namespace ThinkBay.View.Signin_Out;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
		BindingContext = new SignUpViewModel();
    }
}