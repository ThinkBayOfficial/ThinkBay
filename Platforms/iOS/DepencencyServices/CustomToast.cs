using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkOwn.InterFaces;

namespace ThinkOwn.Platforms
{
    internal class CustomToast : IShowToast
    {
        public void ShowToast(string message)
        {
            //var toast = Toast.Make("This is a Toast on iOS!", ToastDuration.Short);

            //// Show the Toast
            //await toast.Show();
        }
    }
}
