using Mopups.Services;

namespace ThinkBay.Popupu.View;

public partial class SignUpOTPPage 
{
    private int _secondsRemaining = 45;
    public SignUpOTPPage()
	{
		InitializeComponent();
        StartCountdownTimer();
    }
    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
    private  void StartCountdownTimer()
    {
        // Start a timer that ticks every second (1000 ms)
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
            }
            else
            {

                // Once the timer reaches 0, display "Time's up!"
                TimeLabel.Text = "Time's up!";
                MopupService.Instance.PopAsync();
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