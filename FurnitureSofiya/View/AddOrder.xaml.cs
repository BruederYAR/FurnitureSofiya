using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FurnitureSofiya.ViewModel;
using FurnitureSofiya.Model;

namespace FurnitureSofiya.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class AddOrder : ContentPage
    {
        public AddOrder()
        {
            InitializeComponent();

            BindingContext = new FurnitureViewModel();

            NavigationPage.SetIconColor(Content, new Color(0,0,0));
        }

        private async void FurnitureListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new AddOrderWork());
        }
    }




}