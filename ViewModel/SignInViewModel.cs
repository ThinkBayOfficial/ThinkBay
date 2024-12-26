using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mopups.Interfaces;
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
            EyeClosed = true;
            EyeOppened = false;
        }
        [ObservableProperty]
        private bool ispassword=true;
        [ObservableProperty]
        private bool eyeOppened;
        [ObservableProperty]
        private bool eyeClosed;
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
        [RelayCommand]
        private async void ShowPasswordFunc()
        {
            Ispassword = !Ispassword;
            if(Ispassword)
            {
                EyeClosed = true;
                EyeOppened = false;
            }
            else
            {
                EyeClosed = false;
                EyeOppened = true;
            }
             
        }
    }
}
