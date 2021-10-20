using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLocation.Model
{
    public class Movie
    {
        // ID - Identificador unico para nossos objetos
        public int ID { get; set; }
        public string Titulo { get; set; }

        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public decimal preco { get; set; }  

    }
}
