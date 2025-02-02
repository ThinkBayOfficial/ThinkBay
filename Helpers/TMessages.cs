using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ThinkOwn.Helpers
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
        public string ProfileHeader { get; set; } = " Tell Us About You!";
        public string ProfileDesc { get; set; } = " Just a few details, and you’re all \r\nset to shop smarter";
        public string PhotDesc { get; set; } = " Add a photo so we can say hi!";
        public string Save { get; set; } = " Save";
        public string Skip { get; set; } = " Skip";
        public string[] Gender { get; set; } = { "Male", "Female", "Others" };
        public string Forgot_Header { get; set; } = "Forgot Your Password ?";
        public string Forgot_Desc { get; set; }  = " No worries! Enter your email or mobile number and \r\nwe’ll help you reset it.";
        public string Forgot_P_Verification { get; set; } = "Enter Your New Password";
        public string OTP_Desc { get; set; } = "Please enter the 4-digit code sent \r\nto";

    }
}
