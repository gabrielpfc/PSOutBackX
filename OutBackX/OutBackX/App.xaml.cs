using System;
using OutBackX.Layers.Business;
//using OutBackX.Layers.Business;
using OutBackX.ViewModel;
using OutBackX.Views;
using Xamarin.Forms;

namespace OutBackX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Método Interno que carrega variáveis (Objetos) Globais
            LoadGlobalVariables();

            var a = new Layers.Data.FuncionarioData();

            if (Model.Global.Funcionario != null)
            {
                MainPage = new NavigationPage(new Views.FuncionarioMainPage());
            }
            else
            {
                MainPage = new NavigationPage(new Views.MainPage());
            }
            
        }

        internal static void MensagemAlerta(string texto)
        {
            App.Current.MainPage.DisplayAlert(texto, "", "Ok");
        }

        internal static void LoadGlobalVariables()
        {
            // Carregando o funcionario Logado
            Model.Global.Funcionario = new FuncionarioBusiness().GetFuncionarioLogged();

            //Carregando a lista de Restaurantes
            Model.Global.Restaurantes = new RestauranteBusiness().GetList();

            // Carregando a lista de Favoritos
            //Model.Global.Eventos = new EventosBusiness().GetList();

        }

        protected override void OnStart()
        {
            // Abrindo tela de funcionarios
            MessagingCenter.Subscribe<ViewModel.MainPageViewModel>(this,
                    "LoginPageAbrir",
                    (sender) =>
                    {
                        MainPage = new NavigationPage(new LoginPage());
                    });


            // Abrindo tela de Restaurantes
            MessagingCenter.Subscribe<ViewModel.MainPageViewModel>(this, "RestaurantePageAbrir",
                (sender) =>
                {
                    MainPage = new NavigationPage(new RestaurantesPage());
                });

            // Abrindo tela de favoritos
            MessagingCenter.Subscribe<ViewModel.MainPageViewModel>(this, "FavoritosPageAbrir",
                (sender) =>
                {
                    MainPage = new NavigationPage(new FavoritosPage());
                });

            // Abrindo tela de Cadastro
            MessagingCenter.Subscribe<ViewModel.MainPageViewModel>(this, "CadastrarPageAbrir",
                (sender) =>
                {
                    MainPage = new NavigationPage(new CadastroPage());
                });

            // Abrindo tela de Administração
            MessagingCenter.Subscribe<ViewModel.MainPageViewModel>(this, "GerirPageAbrir",
                (sender) =>
                {
                    MainPage = new NavigationPage(new GerirPage());
                });

            //Encerrar Sessão
            MessagingCenter.Subscribe<String>("", "Logoff",
                (sender) =>
                {

                    new LogoffBusiness().Logoff();

                    MainPage = new NavigationPage(new Views.MainPage());
                });
        }
         

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
