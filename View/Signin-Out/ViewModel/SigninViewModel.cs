using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkBay.View.Signin_Out.ViewModel
{
    public partial class SigninViewModel :ObservableObject
    {
        public SigninViewModel()
        {
        }
        [ObservableProperty]
        private string emailEntry;
        [ObservableProperty]
        private string passwordEntry;

        [RelayCommand]
        private async void SigninClicked()
        {
            var email = EmailEntry;
            var password = PasswordEntry;
        }
        [RelayCommand]
        private void CreateOne()
        {

        }
        [RelayCommand]
        private void ForgotPassword()
        {
            var email = EmailEntry;
            var password = PasswordEntry;
        }

    }
}
