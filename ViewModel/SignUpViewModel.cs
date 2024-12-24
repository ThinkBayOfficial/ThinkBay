using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkBay.View.Signin_Out;

namespace ThinkBay.ViewModel
{
    [INotifyPropertyChanged]
    public partial class SignUpViewModel
    {
        public SignUpViewModel()
        {
        }
        [RelayCommand]
        private async void LoginClicked()
        {
            App.Current.MainPage = new SignInPage();
        }

    }
}
