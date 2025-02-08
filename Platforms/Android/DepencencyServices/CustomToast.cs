using Android.Widget;
using Google.Android.Material.Snackbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkOwn.InterFaces;

namespace ThinkOwn.Platforms
{
    public class CustomToast : IShowToast
    {
        public void ShowToast(string message)
        {
            //only for android implementation
            var toast = Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long);
            
            toast.Show();

        }


    }
}
