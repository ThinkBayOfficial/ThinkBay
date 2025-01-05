using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkBay.View.Signin_Out.ViewModel
{
    public partial class SignUpViewModel :ObservableObject
    {
        public SignUpViewModel()
        {
            
        }
        [ObservableProperty]
        private string fullName;
        [ObservableProperty]
        private string emailEntry;
        [ObservableProperty]
        private string passwordEntry;
        [ObservableProperty]
        private string confirmPasswordEntry;
        [RelayCommand]
        public void SignupClicked()
        {
            var passwo = PasswordEntry;
            var confirmpass = ConfirmPasswordEntry;
            var email = EmailEntry;
            var name = FullName;
        }
        [RelayCommand]
        public void LoginClicked()
        {
            var passwo = PasswordEntry;
            var confirmpass = ConfirmPasswordEntry;
            var email = EmailEntry;
            var name = FullName;
        }
        //[RelayCommand]
        //public void TermsClicked()
        //{
        //    var passwo = PasswordEntry;
        //    var confirmpass = ConfirmPasswordEntry;
        //    var email = EmailEntry;
        //    var name = FullName;
        //}
    }
}
