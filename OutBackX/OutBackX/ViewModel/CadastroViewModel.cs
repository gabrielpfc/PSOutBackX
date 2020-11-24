using System;
using System.Collections.Generic;
using System.Windows.Input;
using OutBackX.Views.Components;
using Xamarin.Forms;
using OutBackX.Model;
using OutBackX.Layers.Business;

namespace OutBackX.ViewModel
{
    public class CadastroViewModel
    {
        public ICommand CadastrarClicked { get; private set; }

        public ICommand VoltarClicked { get; private set; }

        public Restaurante Restaurante { get; set; }

        public CadastroViewModel()
        {
            Restaurante = new Restaurante();

            Restaurante.nome = "";
            Restaurante.lotacao = "";
            Restaurante.km = 0;
            Restaurante.endereco = "rodovia Washington Luís";

            CadastrarClicked = new Command(() => {
                if (Restaurante.lotacao == "")
                {
                    Restaurante.lotacao = "Regular";
                }
                if (validaCampos()) { 
                    try
                    {
                        new RestauranteBusiness().NovoRestaurante(new Model.Restaurante(Restaurante.km, Restaurante.nome, Restaurante.lotacao, Restaurante.endereco));
                        App.MensagemAlerta("Cadastrado com sucesso");
                    }
                    catch (Exception ex)
                    {
                        App.MensagemAlerta("Usuário ou senha inválidos"+ ex);
                    }
                }
            });

            VoltarClicked = new Command(() => {
                MessagingCenter.Send<CadastroViewModel>(this, "MainPageAbrir");
            });

        }

        private bool validaCampos()
        {
            if (Restaurante.nome.Length < 2)
            {
                App.MensagemAlerta("Insira um nome");
                return false;
            }

            return true;
        }
    }
}
