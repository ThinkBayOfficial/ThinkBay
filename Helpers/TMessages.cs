using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ThinkBay.Helpers
{
    public  class TMessages 
    {  
        public string LoginHeader { get; set; } = "Let’s sign you in ";
        public string LoginSub { get; set; } = "Welcome Back! We\r\nmissed you.";
        public string ForGotPass { get; set; } = "Forgot Password?";
        public string DontHave { get; set; } = " Don’t have an account?";
        public string Create  { get; set; } = " Don’t have an account?";
        public string Create_One { get; set; } = "Create One\r\n";
        public string Conditions { get; set; } = "Agree on our Terms & Conditions";
        public string AlreadyHave { get; set; } = " Already have an account?";

        public string Login { get; set; } = "Login";
        public string OTPDescription { get; set; } = "Please enter the 4-digit code sent \r\nto";
        public string Skip { get; set; } = " Skip";

    }
}
