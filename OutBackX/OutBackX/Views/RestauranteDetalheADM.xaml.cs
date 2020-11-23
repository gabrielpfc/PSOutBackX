using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OutBackX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestauranteDetalheADM : ContentPage
    {
        public RestauranteDetalheADM()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<ViewModel.RestauranteDetalheADMViewModel>(this, "VoltarRestaurantesPageAbrir",
                        (sender) =>
                        {
                            Navigation.PopAsync();
                        });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<Model.Restaurante>(this, "VoltarRestaurantesPageAbrir");

        }
    }
}