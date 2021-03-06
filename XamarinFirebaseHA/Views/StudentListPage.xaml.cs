﻿
using Xamarin.Forms;
using XamarinFirebaseHA.ViewModel;

namespace XamarinFirebaseHA.Views
{
    public partial class StudentListPage : ContentPage
    {
        ListMVVM listMVVM;
        public StudentListPage()
        {
            InitializeComponent();
            BindingContext = listMVVM = new ListMVVM(this);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await listMVVM.onAppering();
        }

        async void Handle_ItemAppearing(object sender, Xamarin.Forms.ItemVisibilityEventArgs e)
        {
            await listMVVM.itemAppering((Student)e.Item);
        }
    }
}
