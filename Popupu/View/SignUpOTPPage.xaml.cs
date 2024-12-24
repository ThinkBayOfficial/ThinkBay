using Mopups.Services;

namespace ThinkBay.Popupu.View;

public partial class SignUpOTPPage 
{
	public SignUpOTPPage()
	{
		InitializeComponent();
	}
    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}