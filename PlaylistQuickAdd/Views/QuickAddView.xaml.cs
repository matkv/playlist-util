using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PlaylistQuickAdd.Views;

public sealed partial class QuickAddView
{
    public QuickAddView()
    {
        InitializeComponent();
    }

    private void StackPanel_Tapped(object sender, Microsoft.UI.Xaml.Input.TappedRoutedEventArgs e)
    {

        var selectedSong = (sender as StackPanel).DataContext as Models.Track;

        if (selectedSong != null)
        {
            var playlist = (DataContext as ViewModels.PlaylistsViewModel).Playlists;

            if (playlist != null)
            {
                //playlist.AddTrack(selectedSong);
            }
        }

    }
}