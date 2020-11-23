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
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<ViewModel.CadastroViewModel>(this, "MainPageAbrir",
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

            MessagingCenter.Unsubscribe<ViewModel.CadastroViewModel>(this, "MainPageAbrir");

        }
    }
}