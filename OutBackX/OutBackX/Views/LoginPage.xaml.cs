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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<ViewModel.LoginViewModel>(this, "MainPageAbrir",
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

            MessagingCenter.Subscribe<ViewModel.LoginViewModel>(this, "LoginSucesso",
                        (sender) =>
                        {
                            this.Navigation.PushAsync(new FuncionarioMainPage());
                        });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<ViewModel.LoginViewModel>(this, "MainPageAbrir");

        }
    }
}