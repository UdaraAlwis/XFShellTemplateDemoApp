using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFShellTemplateDemoApp.Infrastructure;

namespace XFShellTemplateDemoApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command OpenWebCommand { get; }

        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }
    }
}