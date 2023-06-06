using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MyApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCompatibility()
                    .ConfigureMauiHandlers((handlers) => {
#if ANDROID
						handlers.AddHandler(typeof(MyApp.Controls.BorderedEntry),typeof(MyApp.Platforms.Android.Renderers.BorderedEntryRenderer));
#endif
                    });

        return builder.Build();

    }
}
