﻿using Acme.PhoneBookDemo.Models.Tenants;
using Acme.PhoneBookDemo.ViewModels;
using Xamarin.Forms;

namespace Acme.PhoneBookDemo.Views
{
    public partial class TenantsView : ContentPage, IXamarinView
    {
        public TenantsView()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((TenantsViewModel)BindingContext).LoadMoreTenantsIfNeedsAsync(e.Item as TenantListModel);
        }
    }
}