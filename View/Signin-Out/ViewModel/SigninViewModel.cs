using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkOwn.Helpers;
using ThinkOwn.InterFaces;

using ThinkOwn.View.Signin_Out.View;

namespace ThinkOwn.View.Signin_Out.ViewModel
{
    public partial class SigninViewModel :ObservableObject
    {
        private IShowToast _showtoast;
        public SigninViewModel(IShowToast showToast)
        {
            _showtoast = showToast;
        }
        [ObservableProperty]
        private string emailEntry;
        [ObservableProperty]
        private string passwordEntry;
        [ObservableProperty]
        private bool ispassword = true;
        [ObservableProperty]
        private bool ispasswordshowiconoppen = false;
        [ObservableProperty]
        private bool ispasswordshowiconclossed = true;

        [RelayCommand]
        private async void SigninClicked()
        {
            var testvalue = T_Preferences.LOGIN_DATA;
            var email = EmailEntry;
            var password = PasswordEntry;
            

        }
        [RelayCommand]
        private void CreateOne()
        {
            App.Current.MainPage = new SignUpView(_showtoast);
        }
        [RelayCommand]
        private void ForgotPassword()
        {
            var email = EmailEntry;
            var password = PasswordEntry;
            App.Current.MainPage.Navigation.PushModalAsync(new ForgotPassword());
        }
        [RelayCommand]
        private void CheckVisibility()
        {
            Ispassword = !Ispassword;
            if (Ispassword)
            {
                Ispasswordshowiconclossed = true;
                Ispasswordshowiconoppen = false;
            }
            else
            {
                Ispasswordshowiconclossed = false;
                Ispasswordshowiconoppen = true;
            }
        }

    }
}
