using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using Mopups.Interfaces;
using Mopups.Services;
using ThinkBay.Helpers;
using ThinkBay.View.Signin_Out;
using UraniumUI;

namespace ThinkBay
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
            
            
            
            builder.Services.AddSingleton<IPopupNavigation>(MopupService.Instance);
            //dependency injection for  model 
            //dependency injection for view model 


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
