﻿using Microsoft.Extensions.Logging;
using ThinkBay.Helpers;

namespace ThinkBay
{
    public static class MauiProgram
    {
        
        public static MauiApp CreateMauiApp()
            
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                   
                });
            builder.Services.AddSingleton<TMessages>();
            
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
