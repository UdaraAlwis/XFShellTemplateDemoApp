using System;
using System.ComponentModel;
using Xamarin.Forms;
using XFShellTemplateDemoApp.Models;
using XFShellTemplateDemoApp.Services;
using XFShellTemplateDemoApp.ViewModels;

namespace XFShellTemplateDemoApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [QueryProperty("ItemId", "itemid")]
    public partial class ItemDetailPage : ContentPage
    {
        private readonly ItemDetailViewModel _viewModel;
        private string _itemId;

        public string ItemId
        {
            get => _itemId;
            set => _itemId = Uri.UnescapeDataString(value);
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemDetailViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            _viewModel.LoadItemCommand.Execute(ItemId);
        }
    }
}