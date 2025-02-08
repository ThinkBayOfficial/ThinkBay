using ThinkOwn.Helpers;
using ThinkOwn.View.Signin_Out;
using ThinkOwn.View.Features;
using ThinkOwn.View.Signin_Out.View;
using ThinkOwn.Popupu.View;
using ThinkOwn.InterFaces;

namespace ThinkOwn
{
    public partial class App : Application
    {
        public static TMessages T_Message { get; private set; }
        
        public static TICons TICon { get; private set; }
        public App(TMessages _message ,TICons _icons,IShowToast showToast)
        {
            InitializeComponent();
            T_Message = _message;
            TICon= _icons;
            //MainPage = new AppShell();

               MainPage = new SplashVideoPage(showToast);
             // MainPage = new SignUpPage();
             //MainPage = new ProfilePage();
             // MainPage = new  ForgotPassword();
             //MainPage = new PasswordVerification();
             // MainPage = new ForgotPasswordOTP();

        }
        
    }
}
