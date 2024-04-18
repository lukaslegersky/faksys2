using faksys2.pages;
using faksys2.Data;
using faksys2.Lidi;

namespace faksys2
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void BTN1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }

        private void BTN2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }

        private void BTN3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThirdPage());
        }

        private void BTN4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FourthPage());
        }

        private void BTN5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PdfPage());
        }
    }

}
