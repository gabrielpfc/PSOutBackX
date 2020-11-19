using OutBackX.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OutBackX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.MainPage());
        }

        protected override void OnStart()
        {
            // Abrindo tela de funcionarios
            MessagingCenter.Subscribe<ViewModel.MainPageViewModel>(this,
                    "FuncionarioMainPageAbrir",
                    (sender) =>
                    {
                        MainPage = new FuncionarioMainPage();
                    });


            // Abrindo tela de Restaurantes
            MessagingCenter.Subscribe<ViewModel.MainPageViewModel>(this, "RestaurantesPageAbrir",
                (sender) =>
                {
                    MainPage = new RestaurantesPage();
                });

            // Abrindo tela de favoritos
            MessagingCenter.Subscribe<ViewModel.MainPageViewModel>(this, "FavoritosPageAbrir",
                (sender) =>
                {
                    MainPage = new FavoritosPage();
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
