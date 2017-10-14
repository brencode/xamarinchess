using Xamarin.Forms;
using XamarinChess.ViewModels;

namespace XamarinChess
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Bind to the view model
            BindingContext = new MainViewModel();
        }
    }
}
