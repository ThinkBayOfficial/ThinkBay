using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkBay.View.Signin_Out;

namespace ThinkBay.ViewModel
{
    public partial class SignInViewModel :BindableObject
    {
        public SignInViewModel()
        {

        }
        [RelayCommand]
        private async void CreateOne()
        {
            
            await App.Current.MainPage.Navigation.PushModalAsync(new SignUpPage());
        }
    }
}
