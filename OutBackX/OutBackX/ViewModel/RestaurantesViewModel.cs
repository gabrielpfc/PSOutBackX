using System;
using System.Collections.Generic;
using System.Windows.Input;
using OutBackX.Layers.Business;
using OutBackX.Views.Components;
using Xamarin.Forms;

namespace OutBackX.ViewModel
{
    public class RestaurantesViewModel
    {

        public ICommand VoltarClicked { get; private set; }

        public ICommand RestauranteTappedCommand { get; private set; }

        public RestaurantesViewModel()
        {
            var ListaRestaurantes = Model.Global.Restaurantes;

            VoltarClicked = new Command(() => {
                MessagingCenter.Send<RestaurantesViewModel>(this, "MainPageAbrir");
            });

            RestauranteTappedCommand = new Command(() =>
            {
                MessagingCenter.Send<Model.Restaurante>(RestauranteSelecionado, "RestauranteDetalheAbrir");
            });

        }

        private Model.Restaurante restauranteSelecionado;
        public Model.Restaurante RestauranteSelecionado
        {
            get
            {
                return restauranteSelecionado;
            }
            set
            {
                restauranteSelecionado = value;
            }
        }

        private IList<Model.Restaurante> listaRestaurantes;
        public IList<Model.Restaurante> ListaRestaurantes
        {
            get
            {
                Model.Global.Restaurantes = new RestauranteBusiness().GetList();
                return Model.Global.Restaurantes;
            }
            set
            {
                Model.Global.Restaurantes = new RestauranteBusiness().GetList();
                ListaRestaurantes = Model.Global.Restaurantes;
            }
        }

    }
}
