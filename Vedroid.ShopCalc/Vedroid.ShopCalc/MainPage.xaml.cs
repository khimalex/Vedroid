using Xamarin.Forms;

namespace Vedroid.ShopCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();
        }

        private void Entry_Completed(System.Object sender, System.EventArgs e)
        {
            (BindingContext as MainPageVM).CalcCommand.Execute(null);
        }
    }
}
