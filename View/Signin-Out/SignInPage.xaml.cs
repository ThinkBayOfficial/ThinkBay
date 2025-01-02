using CommunityToolkit.Mvvm.Input;
using ThinkBay.Helpers;
using ThinkBay.ViewModel;

namespace ThinkBay.View.Signin_Out;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
		BindingContext= new SignInViewModel();
        T_Preferences.LOGIN_DATA = "Done";

    }
	
}