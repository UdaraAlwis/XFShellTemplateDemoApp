using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFShellTemplateDemoApp.Infrastructure;
using XFShellTemplateDemoApp.Models;

namespace XFShellTemplateDemoApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        private Item _item;

        public Item Item
        {
            get => _item;
            private set
            {
                _item = value;
                Title = _item?.Text;
            }
        }

        public Command LoadItemCommand { get; set; }

        public ItemDetailViewModel()
        {
            var item = new Item
            {
                Text = "Sample Item",
                Description = "This is an item description."
            };

            Item = item;

            LoadItemCommand = new Command<string>(async (itemId) => await LoadItem(itemId));
        }

        private async Task LoadItem(string itemId)
        {
            Item = await DataStore.GetItemAsync(itemId);
        }
    }
}
