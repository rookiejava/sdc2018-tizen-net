using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tizen.TV.UIControls.Forms;
using System;

namespace SimpleVideoPlayer
{
    public class MainPageCS : OverlayPage
    {
        public MainPageCS()
        {
            Player = new MediaPlayer
            {
                UsesEmbeddingControls = true,
                AutoPlay = true,
                Source = MediaSource.FromFile("SamsungQLEDTV.mp4")
            };

            Player.PlaybackCompleted += (s, e) =>
            {
                Console.WriteLine("Playback Completed");
            };
        }
    }
}
