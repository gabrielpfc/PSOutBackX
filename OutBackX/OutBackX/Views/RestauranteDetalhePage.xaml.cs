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
    public partial class RestauranteDetalhePage : ContentPage
    {
        public RestauranteDetalhePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<ViewModel.RestauranteDetalheViewModel>(this, "VoltaRestaurantesPageAbrir",
                        (sender) =>
                        {
                            Navigation.PopAsync();
                        });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<ViewModel.RestauranteDetalheViewModel>(this, "VoltaRestaurantesPageAbrir");

        }
    }
}