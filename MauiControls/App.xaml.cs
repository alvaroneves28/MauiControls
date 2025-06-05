using MauiControls.Pages;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navPage = new NavigationPage(new MauiSetValueControls());

            return new Window(navPage);
        }
    }
}