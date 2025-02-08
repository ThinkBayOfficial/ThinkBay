using CommunityToolkit.Maui;
using Firebase.Database;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using Mopups.Interfaces;
using Mopups.Services;
using ThinkOwn.Helpers;
using ThinkOwn.InterFaces;
using ThinkOwn.Platforms;
using ThinkOwn.View.Signin_Out;
using UraniumUI;

namespace ThinkOwn
{
    public static class MauiProgram
    {
        
        public static MauiApp CreateMauiApp()
            
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseUraniumUI()
                .ConfigureMopups()
                .UseUraniumUIMaterial()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FontAwesome.otf", "FontAwesome");

                });
            //dependency injection for class
            builder.Services.AddSingleton<TMessages>();
            builder.Services.AddSingleton<TICons>();

            //dependency injection for page
            builder.Services.AddTransient<IShowToast,CustomToast>();
            
            
            builder.Services.AddSingleton<IPopupNavigation>(MopupService.Instance);
            //dependency injection for  model 
            //dependency injection for view model 
            //backend 
            builder.Services.AddSingleton(new FirebaseClient("https://myapp-2f387-default-rtdb.firebaseio.com"));

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
