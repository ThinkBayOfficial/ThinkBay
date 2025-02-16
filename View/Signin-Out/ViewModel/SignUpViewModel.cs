﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ThinkOwn.Helpers;
using ThinkOwn.InterFaces;

using ThinkOwn.Popupu.View;
using ThinkOwn.View.Signin_Out.View;
using UraniumUI.Converters;

namespace ThinkOwn.View.Signin_Out.ViewModel
{
    public partial class SignUpViewModel : ObservableObject
    {
        private IShowToast _showToast;
        public SignUpViewModel(IShowToast showToast)
        {
            _showToast = showToast;
        }
        [ObservableProperty]
        private string fullName;
        [ObservableProperty]
        private string enterEmail;
        [ObservableProperty]
        private string enterPassword;
        [ObservableProperty]
        private string enterConfirmPassword;
        [ObservableProperty]
        private bool ispassword = true;
        [ObservableProperty]
        private bool ispasswordshowiconoppen = false;
        [ObservableProperty]
        private bool ispasswordshowiconclossed = true;
        [ObservableProperty]
        private bool isconpassword = true;
        [ObservableProperty]
        private bool isconpasswordshowiconoppen = false;
        [ObservableProperty]
        private bool isconpasswordshowiconclossed = true;
        [RelayCommand]
        private  void EmailInfo()
        {

            var toast = _showToast;

            toast.ShowToast("Email is not valid,should be in the fallowing format 'abc@gmail.com' ");




        }
        [RelayCommand]
        private async void PasswordInfo()
        {
            var toast = _showToast;

            toast.ShowToast("Password must be at least 8 characters long, contain an uppercase letter, a number, and a special character");

        }
        [RelayCommand]
        private async void ConfirmPasswordInfo()
        {
            var toast = _showToast;

            toast.ShowToast("Password & ConfirmPassword Should be Same.");
        }


        [RelayCommand]
        private async void SignupClicked()
        {
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{1,}$");
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            var passwordregex = new Regex(pattern);
            if (string.IsNullOrEmpty(FullName))
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Name Canot be Empty", "OK");
                return;
            }
            else if (string.IsNullOrEmpty(EnterEmail))
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Email Canot be Empty", "OK");
                return;
            }
            else if (!emailRegex.IsMatch(EnterEmail))
            { 
                await App.Current.MainPage.DisplayAlert("Alert", "Please enter valid Email", "OK");
                return;
                
            }
            else if (string.IsNullOrEmpty(EnterPassword))
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Password Canot be Empty", "OK");
                return;
            }
            else if(!passwordregex.IsMatch(EnterPassword))
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Password must contain at least 8 characters, one uppercase, one lowercase, one number and one special character", "OK");
                return;
            }
            else if (string.IsNullOrEmpty(EnterConfirmPassword))
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Confirm Password  Canot be Empty", "OK");
                return;
            }
            else if (EnterPassword != EnterConfirmPassword)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Password and Confirm Password must be same", "OK");
                return;
            }
            else
            {

                try
                {
                    //asign values to model and pass to next page
                    // await Mopups.Services.MopupService.Instance.PushAsync(new SignUpOTPPage());
                    var user = await FireBaseHelper.AddUser(EnterEmail, EnterPassword);
                    T_Preferences.LOGIN_DATA = EnterEmail;
                    var toast = _showToast;

                    toast.ShowToast("Done");
                }
                catch (Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                }

            }

        }
        [RelayCommand]
        private void LoginClicked()
        {
            App.Current.MainPage = new SigninView(_showToast);
        }

        [RelayCommand]
        private void MangePasswordVisibility()
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

        [RelayCommand]
        private void MangeconPasswordVisibility()
        {
            Isconpassword = !Isconpassword;
            if (Isconpassword)
            {
                Isconpasswordshowiconclossed = true;
                Isconpasswordshowiconoppen = false;
            }
            else
            {
                Isconpasswordshowiconclossed = false;
                Isconpasswordshowiconoppen = true;
            }
        }
    }
}
