using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkOwn.View.Signin_Out.ViewModel
{
    public partial class ForgotPasswordViewModel : ObservableObject
    {
        public ForgotPasswordViewModel()
        {
            
        }
        [ObservableProperty]
        private string emailEntry;

        [RelayCommand]
        private async void VarifyEmail()
        {
            var user = EmailEntry;
            //check the user available 
            //else show error message 
            //sent email and pass otp as parameter to next page
            //if user available then navigate to OTP page
            App.Current.MainPage.Navigation.PushModalAsync(new ForgotPasswordOTP());
        }
    }
}
