using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ThinkOwn.Helpers;
using ThinkOwn.InterFaces;

using ThinkOwn.View.Signin_Out.View;
using System.Xml.Linq;

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


            //
            try
            {
                // SMTP server details (replace with your domain's SMTP settings)
                string smtpServer = "smtp.hostinger.com"; // Your domain SMTP server (e.g., Hostinger)
                int smtpPort = 587; // Port 587 for TLS, or 465 for SSL
                string fromEmail = "production@thinkown.in"; // Your domain-based email address
                string fromPassword = "Thinkown@2025"; // Your email password
                string toEmail = "rahulsabu27@gmail.com"; // Recipient's Gmail address

                // Create the email message
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromEmail),
                    Subject = "Test Email",
                    Body = "This is a test email sent from a domain-based email account in a .NET MAUI app."
                };
                mailMessage.To.Add(toEmail);

                // Set up the SMTP client with your domain's server details
                var smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true // Use SSL/TLS for encryption
                };

                // Send the email asynchronously
                await Task.Run(() => smtpClient.Send(mailMessage));

                // Show a success message
                //await DisplayAlert("Success", "Email sent successfully!", "OK");
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                await DisplayAlert("Error", $"Failed to send email: {ex.Message}", "OK");
            }

        }

        private async Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
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
