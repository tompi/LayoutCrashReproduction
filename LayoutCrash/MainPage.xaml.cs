using Xamarin.Forms;

namespace LayoutCrash
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.BeginInvokeOnMainThread(() =>
            {
                // This only crashes on iOS
                // Put a breakpoint on this line:
                var size = Lably.FontSize;
                // Try stepping to this line:
                var thisWontHappen = size + 2;
            });
        }
    }
}
