using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkBay.Popupu.View;
using ThinkBay.View.Signin_Out.View;

namespace ThinkBay.View.Signin_Out.ViewModel
{
    public partial class SignUpViewModel : ObservableObject
    {
        public SignUpViewModel()
        {
            
        }
        [ObservableProperty]
        private string fullName;
        [ObservableProperty]
        private string enterEmail;
        [ObservableProperty]
        private string enterPassword;
        [ObservableProperty]
        private string enterConfirmPassword;

        [RelayCommand]
        private async void SignupClicked()
        {
            var username= FullName;
            var email = EnterEmail;
            var password = EnterPassword;
            var confirmPassword = EnterConfirmPassword;
            await Mopups.Services.MopupService.Instance.PushAsync(new SignUpOTPPage());
        }
        [RelayCommand]
        private void LoginClicked()
        {
            App.Current.MainPage = new SigninView();
        }

    }
}
