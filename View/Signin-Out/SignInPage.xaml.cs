using CommunityToolkit.Mvvm.Input;
using ThinkBay.ViewModel;

namespace ThinkBay.View.Signin_Out;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
		BindingContext= new SignInViewModel(); 
		
	}
	
}