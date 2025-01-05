using ThinkBay.Helpers;
using ThinkBay.View.Signin_Out;
using ThinkBay.View.Features;
using ThinkBay.View.Signin_Out.View;

namespace ThinkBay
{
    public partial class App : Application
    {
        public static TMessages T_Message { get; private set; }
        
        public static TICons TICon { get; private set; }
        public App(TMessages _message ,TICons _icons)
        {
            InitializeComponent();
            T_Message = _message;
            TICon= _icons;
            //MainPage = new AppShell();

               MainPage = new SignUpView();
             // MainPage = new SignUpPage();
             //MainPage = new ProfilePage();
             // MainPage = new  ForgotPassword();
             //MainPage = new PasswordVerification();
             // MainPage = new ForgotPasswordOTP();

        }
    }
}
