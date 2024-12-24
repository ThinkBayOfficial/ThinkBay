using Mopups.Interfaces;
using Mopups.Services;
using ThinkBay.Popupu.View;
using ThinkBay.ViewModel;

namespace ThinkBay.View.Signin_Out;

public partial class SignUpPage : ContentPage
{
    IPopupNavigation popupNavigation;
    public SignUpPage()
	{
		InitializeComponent();
        
        BindingContext = new SignUpViewModel();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Mopups.Services.MopupService.Instance.PushAsync(new SignUpOTPPage());
    }
}