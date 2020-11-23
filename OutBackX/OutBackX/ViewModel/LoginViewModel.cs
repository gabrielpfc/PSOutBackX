using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using OutBackX.Views.Components;
using Xamarin.Forms;
using OutBackX.Model;

namespace OutBackX.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Funcionario _funcionario;
        public Funcionario Funcionario
        {
            get
            {
                return _funcionario;
            }
            set
            {
                _funcionario = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand VoltarClicked { get; private set; }

        public ICommand EntrarClicked { get; private set; }

        public LoginViewModel()
        {
            VoltarClicked = new Command(() => {
                MessagingCenter.Send<LoginViewModel>(this, "MainPageAbrir");
            });

            Funcionario = new Funcionario();
            Funcionario.Login = "Admin";
            Funcionario.Senha = "123";


            EntrarClicked = new Command(() => {
                try
                {
                    var funcionario = new Layers.Business.FuncionarioBusiness().Login(Funcionario);

                    App.LoadGlobalVariables();

                    MessagingCenter.Send<LoginViewModel>(this, "LoginSucesso");
                }
                catch (Exception ex)
                {
                    App.MensagemAlerta("Login ou senha inválida. Detalhe: " + ex.Message);
                }
            });
        }

    }
}
