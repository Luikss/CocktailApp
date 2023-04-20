using Microsoft.Maui.Handlers;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Views;
using Windows.Graphics;
using WinRT.Interop;

namespace CocktailApp;

public partial class App : Application
{
    const int WindowWidth = 750;
    const int WindowHeight = 1500;

    public App()
    {
        InitializeComponent();

#if WINDOWS
        WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
        });
#endif

        MainPage = new NavigationPage(new HomePage());
    }
}