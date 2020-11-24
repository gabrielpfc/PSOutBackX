using System;
using System.Collections.Generic;
using System.Windows.Input;
using OutBackX.Views.Components;
using Xamarin.Forms;

namespace OutBackX.ViewModel
{
    public class MainPageViewModel 
    {
        public ICommand BuscarClicked { get; private set; }

        public ICommand FavoritosClicked { get; private set; }

        public ICommand AdminClicked { get; private set; }

        public ICommand CadastrarClicked { get; private set; }

        public MainPageViewModel()
        {

            BuscarClicked = new Command(() => {
                MessagingCenter.Send<MainPageViewModel>(this, "RestaurantePageAbrir");
            });

            FavoritosClicked = new Command(() => {

                MessagingCenter.Send<MainPageViewModel>(this, "FavoritosPageAbrir");
            });

            AdminClicked = new Command(() => {
                MessagingCenter.Send<MainPageViewModel>(this, "LoginPageAbrir");
            }); 
            
            //Botao exclusivo de Funcionarios
            CadastrarClicked = new Command(() => {
                MessagingCenter.Send<MainPageViewModel>(this, "CadastrarPageAbrir");
            });

        }

    }
}
