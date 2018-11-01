using Xamarin.Forms.Xaml;
using Tizen.TV.UIControls.Forms;
using System;

namespace SimpleVideoPlayer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : OverlayPage
    {
        public MainPage()
        {
            InitializeComponent();
            Player.Source = MediaSource.FromFile("SamsungQLEDTV.mp4");
        }

        async void OnPlaybackCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Playback Completed");
            await Player.Seek(0);
            await Player.Start();
        }
    }
}