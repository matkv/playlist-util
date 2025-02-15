using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PlaylistQuickAdd.Views;

/// <summary>
/// An empty page that can be used on its own or navi��gated to within a Frame.
/// </summary>
public sealed partial class HomeView
{
    public HomeView()
    {
        InitializeComponent();
    }
    
    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        HomeViewModel.StartTimer();
    }
    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
        base.OnNavigatedFrom(e);
        HomeViewModel.StopTimer();
    }

}