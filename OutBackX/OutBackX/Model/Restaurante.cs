using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;

namespace OutBackX.Model
{
    public class Restaurante : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _km;
        public int km
        {
            get { return _km; }
            set
            {
                if (_km != value)
                {
                    _km = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String _nome;
        public String nome
        {
            get { return _nome; }
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String _lotacao;
        public String lotacao
        {
            get { return _lotacao; }
            set
            {
                if (_lotacao != value)
                {
                    _lotacao = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public Restaurante()
        {

        }

        public Restaurante(int _km, String _nome, String _lotacao)
        {
            this.km = _km;
            this.nome = _nome;
            this.lotacao = _lotacao;
        }

    }
}
