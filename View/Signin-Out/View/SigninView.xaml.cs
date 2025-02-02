using ThinkOwn.View.Signin_Out.ViewModel;

namespace ThinkOwn.View.Signin_Out.View;

public partial class SigninView : ContentPage
{
	public SigninView()
	{
		InitializeComponent();
		BindingContext= new SigninViewModel();
    }
}