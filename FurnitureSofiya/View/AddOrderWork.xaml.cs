using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FurnitureSofiya.ViewModel;

namespace FurnitureSofiya.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddOrderWork : ContentPage
    {
        public AddOrderWork()
        {
            InitializeComponent();

            BindingContext = new FurnitureMaterialsViewModel();
        }

        private void CostMaterialsEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry entry = (Entry)sender;
            string text = entry.Text;
            if(!text.Any(Char.IsDigit) && text.Length > 0)
            {
                entry.Text = text.Remove(text.Length - 1);
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddOrderMan());
        }
    }
}