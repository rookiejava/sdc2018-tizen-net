using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;

namespace SimpleWatchPhoto
{
    public class MainPageCS : CirclePage
    {
        public MainPageCS()
        {
            var scroller = new CircleScrollView
            {
                Content = new StackLayout
                {
                    Spacing = 20,
                    Padding = new Thickness(0, 30),
                    Children = {
                        new Image { Source = "Tizen.NET_round.png" },
                        new Image { Source = "CircularUI_round.png" },
                        new Image { Source = "TVUI_round.png" }
                    }
                }
            };
            RotaryFocusObject = scroller;
            Content = scroller;
        }
    }
}