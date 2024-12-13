using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace NDOPosDemo
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
                    fonts.AddFont("Geo-Italic.ttf", "GeoItalic");
                    fonts.AddFont("Geo-Regular.ttf", "GeoRegular");
                })
            .UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
