using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFShellTemplateDemoApp.Views;

namespace XFShellTemplateDemoApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("itemdetailpage", typeof(ItemDetailPage));
            Routing.RegisterRoute("newitempage", typeof(NewItemPage));
        }
    }
}
