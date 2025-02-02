using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkOwn.Helpers
{
    public static class T_Preferences
    {
        private static readonly string KEY_LOGIN_DATA= "login_data_key";

        public static string LOGIN_DATA
        {
            get
            {
                return Preferences.Get(KEY_LOGIN_DATA, string.Empty);
            }
            set
            {
                Preferences.Set(KEY_LOGIN_DATA, value);
            }
        }
    }
}
