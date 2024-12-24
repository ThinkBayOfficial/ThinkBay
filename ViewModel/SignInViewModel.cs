using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkBay.View.Signin_Out;

namespace ThinkBay.ViewModel
{
    [INotifyPropertyChanged]
    public partial class SignInViewModel 
    {
        
        public SignInViewModel()
        {

        }
        [ObservableProperty]
        private bool _iSRun;
        [RelayCommand]
        private async void ForgotPassword()
        {
           await App.Current.MainPage.Navigation.PushModalAsync(new ForgotPassword());
        }

        [RelayCommand]
        private async void CreateOne()
        {
            App.Current.MainPage = new SignUpPage();
        }
    }
}
