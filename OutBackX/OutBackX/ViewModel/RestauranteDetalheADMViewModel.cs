using System;
using System.Collections.Generic;
using System.Windows.Input;
using OutBackX.Layers.Business;
using OutBackX.Views.Components;
using Xamarin.Forms;

namespace OutBackX.ViewModel
{
    public class RestauranteDetalheADMViewModel
    {
        public ICommand VoltarClicked { get; private set; }

        public ICommand InformarClicked { get; private set; }

        public ICommand DeletarClicked { get; private set; }

        public ICommand FavoritarClicked { get; private set; }

        public RestauranteDetalheADMViewModel()
        {
            Restaurante = Model.Global.Restaurante;

            Model.Favorito Favorito = new Model.Favorito(Restaurante.km, Restaurante.nome, Restaurante.lotacao, Restaurante.endereco);

            InformarClicked = new Command(() => {
                if (Restaurante.lotacao == "")
                {
                    App.MensagemAlerta("Por favor informe a lotação");
                }
                else
                {
                    try
                    {
                        new RestauranteBusiness().EditarRestaurante(Restaurante);
                        App.MensagemAlerta("Lotação informada com sucesso");
                    }
                    catch (Exception ex)
                    {
                        App.MensagemAlerta("Erro: " + ex);
                    }
                }
            });

            FavoritarClicked = new Command(() => {
                Boolean ok = false;
                try
                {
                    ok = new FavoritoBusiness().NovoFavorito(Favorito);
                }
                catch (Exception ex)
                {
                    App.MensagemAlerta("Erro: " + ex);
                }
                if (ok)
                {
                    App.MensagemAlerta("Favoritado com sucesso!");
                } else
                {
                    App.MensagemAlerta("Favorito já adicionado!");
                }

            });

            VoltarClicked = new Command(() => {
                MessagingCenter.Send<RestauranteDetalheADMViewModel>(this, "VoltarRestaurantesPageAbrir");
            });

            DeletarClicked = new Command(() => {
                try
                {
                    new RestauranteBusiness().DeletarRestaurante(Restaurante);
                    App.MensagemAlerta("Restaurante deletado com sucesso");
                    MessagingCenter.Send<RestauranteDetalheADMViewModel>(this, "VoltarRestaurantesPageAbrir");
                }
                catch (Exception ex)
                {
                    App.MensagemAlerta("Erro: " + ex);
                }
            });
        }
        public RestauranteDetalheADMViewModel(Model.Restaurante _restaurante)
        {
            Restaurante = _restaurante;
            if (Restaurante.lotacao == "")
            {
                Restaurante.lotacao = "Regular";
            }
        }

        private Model.Restaurante restaurante;
        public Model.Restaurante Restaurante
        {
            get
            {
                return restaurante;
            }
            set
            {
                restaurante = value;
            }
        }

    }
}