using System;
using System.Collections.Generic;
using System.Windows.Input;
using OutBackX.Views.Components;
using Xamarin.Forms;
using OutBackX.Layers.Business;

namespace OutBackX.ViewModel
{
    public class FavoritosViewModel
    {
        public ICommand BuscarClicked { get; private set; }

        public ICommand FavoritosClicked { get; private set; }

        public ICommand AdminClicked { get; private set; }

        public ICommand VoltarClicked { get; private set; }

        public FavoritosViewModel()
        {
            var ListaFavoritos = Model.Global.Favoritos;

            VoltarClicked = new Command(() => {
                MessagingCenter.Send<FavoritosViewModel>(this, "MainPageAbrir");
            });
        }

        private IList<Model.Favorito> ListaFavorito;
        public IList<Model.Favorito> ListaFavoritos
        {
            get
            {
                Model.Global.Favoritos = new FavoritoBusiness().GetList();
                return Model.Global.Favoritos;
            }
            set
            {
                Model.Global.Favoritos = new FavoritoBusiness().GetList();
                ListaFavoritos = Model.Global.Favoritos;
            }
        }

    }
}
