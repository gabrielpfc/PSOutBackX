using System;
using OutBackX.Model;
using OutBackX.Layers.Data;
using System.Collections.Generic;

namespace OutBackX.Layers.Business
{
    public class FavoritoBusiness
    {

        public Boolean NovoFavorito(Favorito favorito)
        {
            String mensagem;

            try
            {
                // Grava os dados do novo favorito no dispositivo
                IList<Favorito> listaFavoritos;
                Data.FavoritosData favoritoData = new Data.FavoritosData();
                listaFavoritos = favoritoData.GetList();

                if(listaFavoritos.Count == 0)
                {
                    new FavoritosData().Insert(favorito);
                }
                foreach (var favoritoTemp in listaFavoritos)
                {
                    if (favorito.km == favoritoTemp.km && favorito.nome == favoritoTemp.nome)
                    {
                        return false;

                    }
                    
                    
                }
                new FavoritosData().Insert(favorito);

            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível cadastrar o favorito. \n Detalhe: " +
                    ex.Message;
            }

            return true;

        }

        public IList<Favorito> GetList()
        {

            IList<Favorito> listaFavoritos;

            Data.FavoritosData favoritoData = new Data.FavoritosData();
            listaFavoritos = favoritoData.GetList();

            return listaFavoritos;
        }
    }
}
