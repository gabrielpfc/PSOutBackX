using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;

namespace OutBackX.Model
{
    public class Favorito : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _id;
        [PrimaryKey, AutoIncrement]
        public int id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    NotifyPropertyChanged();
                }
            }
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

        private String _endereco;
        public String endereco
        {
            get { return _endereco; }
            set
            {
                if (_endereco != value)
                {
                    _endereco = value;
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


        public Favorito()
        {

        }

        public Favorito(int _km, String _nome, String _lotacao, String _endereco)
        {
            this.km = _km;
            this.nome = _nome;
            this.lotacao = _lotacao;
            this.endereco = _endereco;
        }

    }
}
