using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteAccessBrasil2.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public int Codigo  { get; set; }
        public int CodMarca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public string Cor{ get; set; }

    }
}