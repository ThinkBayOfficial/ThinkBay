using Mopups.Services;
using System.Net.Mail;
using System.Net;

namespace ThinkBay.Popupu.View;

public partial class SignUpOTPPage 
{
    private int _secondsRemaining = 45;
     public bool isblack;
    public SignUpOTPPage()
	{
		InitializeComponent();

        StartCountdownTimer();
        #region OTP mail sending 

        //string from = "rahulsabu27sep@gmail.com";
        //string pass = "rjjdpguackhljccb";
        //string to = "sidharths31434@gmail.com";
        //MailMessage message = new MailMessage();
        //message.From = new MailAddress(from);
        //message.Subject = "Test";
        //message.To.Add(new MailAddress(to));
        //message.Body = "Test";
        //message.IsBodyHtml = false;
        //var smt = new SmtpClient("smtp.gmail.com")
        //{
        //    Port = 587,
        //    Credentials = new NetworkCredential(from, pass)
        //      ,
        //    EnableSsl = true,
        //};
        //smt.Send(message);
        #endregion

    }
    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }

    [Obsolete]
    private  void StartCountdownTimer()
    {
       
        
        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            
            // If there is still time left
            if (_secondsRemaining > 0)
            {
                // Decrease the remaining seconds by 1
                _secondsRemaining--;

                // Format the remaining time as mm:ss (minutes:seconds)
                var timeFormatted = TimeSpan.FromSeconds(_secondsRemaining).ToString(@"mm\:ss");

                // Update the Label to show the remaining time
                TimeLabel.Text = timeFormatted;
               
                if(_secondsRemaining<10)
                {
                    if (isblack == true)
                    {
                        TimeLabel.TextColor = Color.FromHex("#FFFFFF");
                        isblack = false;
                    }
                    else
                    {
                        TimeLabel.TextColor = Color.FromHex("#FF0000");
                        isblack = true;
                    }

                   
                }
            }
            else
            {

                // Once the timer reaches 0, display "Time's up!"
                TimeLabel.Text = "Time's up!";
                if(Mopups.Services.MopupService.Instance.PopupStack.Count>0)
                {
                    MopupService.Instance.PopAsync();
                }
                
                return false; // Stop the timer
            }

            return true; // Continue the timer (keep it ticking every second)
        });
    }
    private void otpBox1_TextChanged_1(object sender, TextChangedEventArgs e)
    {
        var currentEntry = sender as UraniumUI.Material.Controls.TextField;

        // Move to the next OTP box if current entry has a value
        if (!string.IsNullOrEmpty(currentEntry?.Text))
        {
            // Find the next Entry box
            int currentColumn = Grid.GetColumn(currentEntry);
            if (currentColumn < 3) // There are 4 OTP boxes
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