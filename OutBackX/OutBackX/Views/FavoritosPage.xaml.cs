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
    public partial class FavoritosPage : ContentPage
    {
        public FavoritosPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ViewModel.FavoritosViewModel>(this, "MainPageAbrir",
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

            MessagingCenter.Unsubscribe<ViewModel.FavoritosViewModel>(this, "MainPageAbrir");

        }
    }
}