using ThinkBay.Helpers;
using ThinkBay.View.Signin_Out;

namespace ThinkBay
{
    public partial class App : Application
    {
        public static TMessages T_Message { get; private set; }
        public App(TMessages _message)
        {
            InitializeComponent();
            T_Message = _message;

            //MainPage = new AppShell();

            MainPage = new SignInPage();
        }
    }
}
