using Avalonia;
using Avalonia.ReactiveUI;

namespace VideoDuplicateFinder.gui {
	class Program {
		static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

		public static AppBuilder BuildAvaloniaApp()
			=> AppBuilder.Configure<App>()
				.UsePlatformDetect().UseReactiveUI()
				.LogToTrace();
	}
}
