using System;
using System.Collections.Generic;
using System.Text;

namespace OutBackX.Model
{
    public class Global
    {
        public static Funcionario Funcionario { get; set; }

        public static Restaurante Restaurante { get; set; }

        public static IList<Restaurante> Restaurantes { get; set; }

        public static IList<Favorito> Favoritos { get; set; }

    }
}


