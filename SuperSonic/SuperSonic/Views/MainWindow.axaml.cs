using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SuperSonic.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Root_OnLoaded(object? sender, RoutedEventArgs args)
    {
        QueryTextBox.Focus();
    }
}
