using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using SQLite;
using SQLiteNetExtensions.Attributes;

namespace OutBackX.Model
{
    public class Funcionario : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private String _Login;

        [PrimaryKey]
        public String Login
        {
            get { return _Login; }
            set
            {
                if (_Login != value)
                {
                    _Login = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String _Senha;
        public String Senha
        {
            get { return _Senha; }
            set
            {
                if (_Senha != value)
                {
                    _Senha = value;
                    NotifyPropertyChanged();
                }
            }

        }


        public Funcionario()
        {

        }

        public Funcionario(string _Login, string _Senha)
        {
            this.Login = _Login;
            this.Senha = _Senha;
        }

    }
}
