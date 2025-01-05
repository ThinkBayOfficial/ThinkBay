using ThinkBay.View.Signin_Out.ViewModel;

namespace ThinkBay.View.Signin_Out.View;

public partial class SigninView : ContentPage
{
	public SigninView()
	{
		InitializeComponent();
		BindingContext= new SigninViewModel();
    }
}