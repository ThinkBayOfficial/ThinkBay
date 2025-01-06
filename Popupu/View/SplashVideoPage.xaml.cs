using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Views;
using Mopups.Services;
using ThinkBay.View.Signin_Out.View;
using UraniumUI.ViewExtensions;

namespace ThinkBay.Popupu.View;

public partial class SplashVideoPage : ContentPage
{
    private int _secondsRemaining = 10;
    public SplashVideoPage()
    {
        InitializeComponent();
        VideoPlayer.ShouldAutoPlay = true;
         

        // Create a Timer and schedule the task to run after the delay
         
        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {

            // If there is still time left
            if (_secondsRemaining > 0)
            {
                // Decrease the remaining seconds by 1
                _secondsRemaining--;

                // Format the remaining time as mm:ss (minutes:seconds)
                var timeFormatted = TimeSpan.FromSeconds(_secondsRemaining).ToString(@"mm\:ss");
                if(_secondsRemaining==1)
                {
                    App.Current.MainPage = new SigninView();
                }
               

               
            }
            else
            {
 

                return false; // Stop the timer
            }

            return true; // Continue the timer (keep it ticking every second)
        });

        
    }
         
    //private async void PlayVideo()
    //{
      
       

    //    VideoPlayer.StateChanged += OnMediaItemFinished;

    //}

    //private void OnMediaItemFinished(object? sender, MediaStateChangedEventArgs e)
    //{
       
    //}
}