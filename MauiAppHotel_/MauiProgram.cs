using Microsoft.Extensions.Logging;

namespace MauiAppHotel_
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
                    fonts.AddFont("kalam-bold.ttf", "KalamBold");
                    fonts.AddFont("kalam-regular.ttf", "KalamRegular");
                    fonts.AddFont("kalam-light.ttf", "KalamLight");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
