namespace ThinkBay.View.Signin_Out;

public partial class ForgotPasswordOTP : ContentPage
{
	public ForgotPasswordOTP()
	{
		InitializeComponent();
	}
    private void OtpBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        
    }
    private void OnSubmitClicked(object sender, EventArgs e)
    {
       // string otp = otpBox1.Text + otpBox2.Text + otpBox3.Text + otpBox4.Text + otpBox5.Text;

        // Handle OTP submission logic (e.g., validate OTP)
        //DisplayAlert("OTP Submitted", otp, "OK");
    }

    private void otpBox1_TextChanged(object sender, TextChangedEventArgs e)
    {
        
    }

    private void otpBox1_TextChanged_1(object sender, TextChangedEventArgs e)
    {
        var currentEntry = sender as UraniumUI.Material.Controls.TextField;

        // Move to the next OTP box if current entry has a value
        if (!string.IsNullOrEmpty(currentEntry?.Text))
        {
            // Find the next Entry box
            int currentColumn = Grid.GetColumn(currentEntry);
            if (currentColumn < 4) // There are 5 OTP boxes
            {
                var nextEntry = (UraniumUI.Material.Controls.TextField)this.FindByName($"otpBox{currentColumn + 2}");
                nextEntry?.Focus();
            }
        }
        else
        {

        }
    }
}