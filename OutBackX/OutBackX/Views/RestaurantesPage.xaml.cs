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
    public partial class RestaurantesPage : ContentPage
    {
        public RestaurantesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<Model.Restaurante>(this, "RestauranteDetalheAbrir",
            (sender) =>
            {
                Model.Global.Restaurante = sender;
//                MessagingCenter.Unsubscribe<Model.Restaurante>(this, "RestauranteDetalheAbrir");
                if (Model.Global.Funcionario != null)
                {
                    this.Navigation.PushAsync(new RestauranteDetalheADM());
                }
                else
                {
                    this.Navigation.PushAsync(new RestauranteDetalhePage());
                }

                
            });

            MessagingCenter.Subscribe<ViewModel.RestaurantesViewModel>(this, "MainPageAbrir",
            (sender) =>
            {
                if (Model.Global.Funcionario != null)
                {
                    this.Navigation.PushAsync(new FuncionarioMainPage());
                }
                else
                {
                    this.Navigation.PushAsync(new MainPage());
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<ViewModel.RestaurantesViewModel>(this, "MainPageAbrir");
            MessagingCenter.Unsubscribe<Model.Restaurante>(this, "RestauranteDetalheAbrir");

        }
    }
}