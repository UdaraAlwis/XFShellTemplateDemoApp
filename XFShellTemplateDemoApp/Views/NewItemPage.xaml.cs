using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XFShellTemplateDemoApp.Models;
using XFShellTemplateDemoApp.ViewModels;

namespace XFShellTemplateDemoApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        private readonly NewItemViewModel _viewModel;

        public NewItemPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new NewItemViewModel();
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", _viewModel.Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}