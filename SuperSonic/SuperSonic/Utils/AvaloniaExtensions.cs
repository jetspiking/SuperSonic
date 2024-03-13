using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;

namespace SuperSonic.Utils;

internal static class AvaloniaExtensions
{
    public static TopLevel TryGetTopLevel(this IApplicationLifetime lifetime) =>
        (lifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow
        ?? (lifetime as ISingleViewApplicationLifetime)?.MainView as TopLevel;
}
