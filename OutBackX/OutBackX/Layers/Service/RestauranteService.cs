using System;
using System.Collections.Generic;
using OutBackX.Model;

namespace OutBackX.Layers.Service
{
    public class RestauranteService
    {
        public IList<Restaurante> Get()
        {
            IList<Restaurante> restaurantes = new List<Restaurante>() { new Restaurante(
                40, "McDonalds", "Regular")};

            return restaurantes;
        }
    }
}
