using System;
using OutBackX.Model;
using OutBackX.Layers.Data;
using System.Collections.Generic;

namespace OutBackX.Layers.Business
{
    public class RestauranteBusiness
    {

        public void NovoRestaurante(Restaurante restaurante)
        {
            String mensagem;

            try
            {
                // Grava os dados do novo restaurante no dispositivo
                new RestauranteData().Insert(restaurante);
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível cadastrar o restaurante. \n Detalhe: " +
                    ex.Message;
            }
            
            

        }

        public void DeletarRestaurante(Restaurante restaurante)
        {
            String mensagem;

            try
            {
                // Deleta os dados restaurante no dispositivo
                new RestauranteData().Delete(restaurante);
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível cadastrar o restaurante. \n Detalhe: " +
                    ex.Message;
            }
        }

        public void EditarRestaurante (Restaurante restaurante)
        {
            String mensagem;

            try
            {
                // Edita os dados do restaurante no dispositivo
                new RestauranteData().Update(restaurante);
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível cadastrar o restaurante. \n Detalhe: " +
                    ex.Message;
            }
        }

        public IList<Restaurante> GetList()
        {

            IList<Restaurante> listaRestaurantes;

            Data.RestauranteData restauranteData = new Data.RestauranteData();
            listaRestaurantes = restauranteData.GetList();

            if (listaRestaurantes == null || listaRestaurantes.Count < 1)
            {
                listaRestaurantes = new Service.RestauranteService().Get();

                foreach (var restaurante in listaRestaurantes)
                {
                    restauranteData.Insert(restaurante);
                }
            }

            return listaRestaurantes;
        }
    }
}
