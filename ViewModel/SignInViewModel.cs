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
        bool q_hi;

        [RelayCommand]
        private async void CreateOne()
        {

            Q_hi = true;
            // await App.Current.MainPage.Navigation.PushModalAsync(new SignUpPage());

             App.Current.MainPage = new SignUpPage();
            Q_hi = false;
        }
    }
}
