using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFShellTemplateDemoApp.Services;
using XFShellTemplateDemoApp.Views;

namespace XFShellTemplateDemoApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
