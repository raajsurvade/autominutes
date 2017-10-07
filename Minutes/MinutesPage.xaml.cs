using Xamarin.Forms;

namespace Minutes
{
    public partial class MinutesPage : ContentPage
    {
        public MinutesPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (Device.OS == TargetPlatform.iOS)
            {
                
            }
            else if (Device.OS == TargetPlatform.Android)
            {

            }
        }
        public interface Imethod1
        {
            void method1();
        }
    }
}
