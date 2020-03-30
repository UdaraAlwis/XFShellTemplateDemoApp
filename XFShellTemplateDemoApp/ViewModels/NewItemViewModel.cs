using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFShellTemplateDemoApp.Infrastructure;
using XFShellTemplateDemoApp.Models;

namespace XFShellTemplateDemoApp.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private Item _item;

        public Item Item
        {
            get => _item;
            set
            {
                SetProperty(ref _item, value);
            }
        }

        public NewItemViewModel()
        {
            var item = new Item
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Item name",
                Description = "This is an item description."
            };

            Item = item;
        }
    }
}